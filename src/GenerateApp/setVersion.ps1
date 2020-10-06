dotnet tool restore
$TimeNow = Get-Date
$d = $TimeNow.ToUniversalTime()
$year = $TimeNow.Year
$startOfYear = Get-Date -Year $year -Month 1 -Day 1 -Hour 0 -Minute 0 -Second 0 -Millisecond 0

$diff = NEW-TIMESPAN -Start $startOfYear -End $TimeNow
#$diff.TotalSeconds -as [int]

$dateToPrint=[long] $d.ToString('yyyyMMddHHmmss')
$result = $dateToPrint % 2
if($result -eq 0){
	$moniker = "$(dotnet moniker -s moby)-$dateToPrint"
	}
else{
	$moniker = "$(dotnet moniker -s moniker)-$dateToPrint"
	}

Write-Host $moniker



$assemblyVersion=$d.ToString("1.yyyy.1MM.1dd") #+"-beta"+ $d.ToString("1HHmmss");
$version=$assemblyVersion #$d.ToString("1.yyyy.") + ($diff.TotalSeconds -as  [int]).ToString() +"-beta"+ $d.ToString("ss");

$releaseNotes = "For using please read github.com/ignatandrei/generateapp/"
# $releaseNotes +="\r\n"
$releaseNotes += (";BuildNumber $env:BUILD_BUILDNUMBER with name "+ $moniker)
# $releaseNotes +="\r\n"
#$releaseNotes += ";author $env:BUILD_SOURCEVERSIONAUTHOR"
# $releaseNotes +="\r\n"
#$releaseNotes += ";message $env:BUILD_SOURCEVERSIONMESSAGE"
# $releaseNotes +="\r\n"
$releaseNotes +=";source for this release //github.com/ignatandrei/generateapp/commit/$env:BUILD_SOURCEVERSION"
$releaseNotes

$projects = Get-ChildItem -Recurse "." -include *.csproj

foreach ($item in $projects) {

	Write-Host $item.Name
	$folder= Split-Path -Path $item.FullName
	Push-Location $folder
	dotnet-property $item.Name AssemblyVersion:"$assemblyVersion"
	dotnet dotnet-property $item.Name AssemblyVersion:"$assemblyVersion"
	
	dotnet-property $item.Name Version:"$version"
	dotnet dotnet-property $item.Name Version:"$version"

	dotnet-property $item.Name PackageReleaseNotes:"$releaseNotes"
	dotnet dotnet-property $item.Name PackageReleaseNotes:"$releaseNotes"

	dotnet-property $item.Name AssemblyTitle:"generateapp $moniker"
	dotnet dotnet-property $item.Name AssemblyTitle:"generateapp $moniker"

	Pop-Location
}