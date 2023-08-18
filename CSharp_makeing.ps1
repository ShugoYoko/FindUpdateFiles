$path = (Convert-Path .)
$solunton = Read-Host “ソリューション名を指定してください”
$type=Read-Host "作成するアプリケーションを指定してください.(console)"

#ソリューションファイルのある階層
$directoryPath=Join-Path $path $solunton

if($type -eq "console"){

New-Item $directoryPath -ItemType Directory
Set-Location $directoryPath
dotnet new sln

$projectFolder=$solunton+".Con"
#プロジェクトファイルのある階層
$projectPath=Join-Path $directoryPath $projectFolder
New-Item $projectPath -ItemType Directory
Set-Location $projectPath
dotnet new console

Set-Location $directoryPath
$projectFile=$projectFolder+".csproj"
$projectFilePath=Join-Path $projectPath $projectFile
dotnet sln add $projectFilePath

$xunitTest=$solunton+".Tests"
dotnet new xunit -o $xunitTest

$xunitTestproject=$xunitTest+".csproj"
$xunitTestPath=Join-Path $directoryPath $xunitTest | Join-Path -ChildPath $xunitTestproject
dotnet sln add $xunitTestPath
dotnet add $xunitTestPath reference $projectFilePath


}
else{
Read-Host “未実装”
}

