& cd "Ace.Geograpi.Application.Tests"
& .\run-test-coverage-mtp.ps1
& cd ..

& cd "Ace.Geograpi.Infrastructure.IntegrationTests"
& .\run-test-coverage-mtp.ps1
& cd ..

& cd "Ace.Geograpi.Web.Tests"
& .\run-test-coverage-mtp.ps1
& cd ..

Write-Host "Test coverage completed."
Start-Sleep -Seconds 2;
