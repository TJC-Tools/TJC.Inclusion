# NuGet Package Template
This repository is a template for **Public C# Libraries** that will be published as **NuGet Packages**.

## Setup
1. Clone the repository
2. Open `Testing.sln` & create `LibraryName/TJC.LibraryName.csproj` & `LibraryName.Tests/TJC.LibraryName.Tests.csproj`
3. Set **NuGet Package** settings in the `.csproj`, such as `RepositoryUrl`, `PackageReadmeFile`, `Title`, `Description` & `Author`
4. Copy `Nuget.config` into the `LibraryName` directory
5. In `workflows` replace the `{REPLACE_ME}` placeholders
6. Replace this `README.md` with something relevant to the library
7. Amend the initial commit & force push the changes
8. ~~Set `GitHub NuGet Package` visibility to `public`~~
9. Import repository permissions from [ruleset](.github/ruleset.json) & delete it
10. Add badges to `README.md` (if applicable)
