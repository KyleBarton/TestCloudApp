ECHO OFF
"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" ..\HelloFriend\HelloFriend\HelloFriend.csproj /t:package /p:DeployIisAppPath="Default Web Site"
eb deploy
ECHO ON
