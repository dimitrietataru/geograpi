$Project = "Ace.Geograpi.Aplication";
$Root = "..\.cov";
$ReportGeneratorPath = ".nuget\packages\reportgenerator\5.3.8\tools\net8.0\ReportGenerator.dll";

dotnet test --collect:"XPlat Code Coverage" --settings .\runsettings --results-directory "$Root\raw\$Project";
dotnet "$env:USERPROFILE\$ReportGeneratorPath" "-reports:$Root\raw\$Project\*\coverage.cobertura.xml" "-targetdir:$Root\reports\$Project" "-historydir:$Root\reports\.history\$Project" -reporttypes:Html;
dotnet "$env:USERPROFILE\$ReportGeneratorPath" "-reports:$Root\raw\$Project\*\coverage.cobertura.xml" "-targetdir:$Root\reports\$Project" "-historydir:$Root\reports\.history\$Project" -reporttypes:Badges;

Write-Host "`n" "Test coverage for $Project completed." "`n";
Start-Sleep -Seconds 2;
