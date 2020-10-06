dotnet tool restore
dotnet tool list
#cd ./GenerateAppBL
#dotnet build
#dotnet pack  --include-source --include-symbols --output ../output/
#c
cd ./GenerateAppTool
Write-Host "start copy"
Copy-Item -Path ../GenerateApp/wwwroot/GenerateAll/* -Destination ./GenerateAll/ -Recurse
Write-Host "end copy"
dotnet build
dotnet pack  --include-source --include-symbols --output ../output/
cd ..

