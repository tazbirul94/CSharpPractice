https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?tabs=netcore-cli

Go to the Realease folder where the package is being publishe dand then run the following command:
dotnet nuget push DemoLibrary-taz.1.0.0.nupkg --api-key <YOU_NUGETORG_API_KEY> --source https://api.nuget.org/v3/index.json