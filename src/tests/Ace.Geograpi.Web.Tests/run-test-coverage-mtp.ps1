$Project = "Ace.Geograpi.Web";
$CoverageRoot = Join-Path $PSScriptRoot "..\.cov";
$CoverageRaw = Join-Path $CoverageRoot "raw\$Project";

Remove-Item $CoverageRaw -Recurse -Force -ErrorAction SilentlyContinue;

dotnet test --project $PSScriptRoot --results-directory $CoverageRaw `
    --coverlet `
    --coverlet-output-format cobertura `
    --coverlet-file-prefix $Project `
    --coverlet-include "[$Project]*" `
    --coverlet-exclude-by-file "**/*.g.cs" `
    --coverlet-exclude-by-file "**/GlobalUsings.cs" `
    --coverlet-exclude-by-file "**/AppConfiguration*.cs" `
    --coverlet-exclude-by-file "**/Program.cs";

if ($LASTEXITCODE -ne 0) {
    Write-Host "`n" "Tests for $Project failed. Exit code: $LASTEXITCODE." "`n";
    exit $LASTEXITCODE;
}

$ReportGeneratorRoot = dotnet msbuild $PSScriptRoot -getProperty:PkgReportGenerator;
$TargetFramework = dotnet msbuild $PSScriptRoot -getProperty:TargetFramework;
$ReportGenerator = Join-Path $ReportGeneratorRoot "tools\$TargetFramework\ReportGenerator.dll";

dotnet $ReportGenerator `
    "-reports:$CoverageRoot\raw\$Project\*.cobertura.*xml" `
    "-targetdir:$CoverageRoot\reports\$Project" `
    "-historydir:$CoverageRoot\reports\.history\$Project" `
    "-reporttypes:Html;Badges" `
    "-verbosity:Warning" `
    "settings:applyMaximumGroupingLevel=true";

Write-Host "`n" "Test coverage for $Project completed." "`n";
Start-Sleep -Seconds 2;
