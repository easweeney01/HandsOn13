dotnet restore

dotnet format --verify-no-changes
if ($LASTEXITCODE -ne 0) { exit 1 }

dotnet build -c Debug
dotnet build -c Release

dotnet test

doxygen