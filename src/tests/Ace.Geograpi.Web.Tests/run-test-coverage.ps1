$Project = "Ace.Geograpi.Web";
$Root = "..\.cov";
$ReportGeneratorPath = ".nuget\packages\reportgenerator\5.3.8\tools\net8.0\ReportGenerator.dll";

dotnet test --collect:"XPlat Code Coverage" --settings .\runsettings --results-directory "$Root\raw\$Project";
dotnet "$env:USERPROFILE\$ReportGeneratorPath" "-reports:$Root\raw\$Project\*\coverage.cobertura.xml" "-targetdir:$Root\reports\$Project" "-historydir:$Root\reports\.history\$Project" -reporttypes:Html;
dotnet "$env:USERPROFILE\$ReportGeneratorPath" "-reports:$Root\raw\$Project\*\coverage.cobertura.xml" "-targetdir:$Root\reports\$Project" "-historydir:$Root\reports\.history\$Project" -reporttypes:Badges;

Read-Host -Prompt "Press any key to continue.."
