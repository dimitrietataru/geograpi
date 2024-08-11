dotnet test --collect:"XPlat Code Coverage" --settings .\runsettings --results-directory _CoverageResults;

dotnet "$env:USERPROFILE\.nuget\packages\reportgenerator\5.3.8\tools\net8.0\ReportGenerator.dll" "-reports:_CoverageResults\*\coverage.cobertura.xml" "-targetdir:_CoverageReport\Application" "-historydir:_CoverageReport\_History\Application" -reporttypes:Html;
dotnet "$env:USERPROFILE\.nuget\packages\reportgenerator\5.3.8\tools\net8.0\ReportGenerator.dll" "-reports:_CoverageResults\*\coverage.cobertura.xml" "-targetdir:_CoverageReport\Application" "-historydir:_CoverageReport\_History\Application" -reporttypes:Badges;

Read-Host -Prompt "Press any key to continue.."
