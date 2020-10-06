dotnet tool restore
dotnet tool list
#cd ./GenerateAppBL
#dotnet build
#dotnet pack  --include-source --include-symbols --output ../output/
#cd ..
cd ./GenerateAppTool
dotnet build
dotnet pack  --include-source --include-symbols --output ../output/

