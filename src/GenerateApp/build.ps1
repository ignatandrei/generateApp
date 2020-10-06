dotnet tool restore
dotnet tool list
#cd ./GenerateAppBL
#dotnet build
#dotnet pack  --include-source --include-symbols --output ../output/
#c
cd ./GenerateAppTool
Write-Host "start copy"
Compress-Archive -Path ../GenerateApp/wwwroot/GenerateAll/* -DestinationPath ./GenerateAll/GenerateAll.zip 
Write-Host "end copy"
dotnet build
dotnet pack  --include-source --include-symbols --output ../output/
cd ..

