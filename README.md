# Blazin Catfork

just like regular (catfork Live site)[https://stefanbemelmans.github.io/catfork]
(catfork Repo)[https://github.com/stefanbemelmans/catfork]
but written in C# with .NET Core and Blazor.

Just updated the UI to modern times, so pictures will be coming soon. 

# Directory Structure
* Artifacts - Build outputs go here. Doing a build.cmd/build.sh generates artifacts here (nupkgs, dlls, pdbs, etc.)
* Assets - Image Logos etc.
* Build - Build customizations (custom msbuild files/psake/fake/albacore/etc) scripts
* Documentation - DocFx folder
* Lib - Things that can NEVER exist in a nuget package
* Packages - NuGet packages
* Samples (optional) - Sample projects
* Source - Main projects (the product code)
* Tests - Test projects
* .gitignore - started with VisualStudio one from Github update as needed.
* build.ps - (optional) Powershell script to Bootstrap the build
* global.json - (optional) specify required SDK
* Nuget.config - specify Nuget sources
* README.md
* UNLICENSE.md
