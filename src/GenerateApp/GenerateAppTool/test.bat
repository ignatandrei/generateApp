del *.nupkg 
dotnet tool uninstall -g GenerateAppTool
dotnet pack --output ./
dotnet tool install -g GenerateAppTool --add-source ./ 
GenerateAppTool 
