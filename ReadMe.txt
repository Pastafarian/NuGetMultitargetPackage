NuGet Multitarget Package Example

Basic example of how to handle multi platform support for NuGet packages for both the .NET Framework and .NET Core. 

Code to go with article on Medium. 

https://medium.com/@SicknoteSteve/nuget-targeting-both-net-standard-and-the-net-framework-326a16266ca4


To create the package, navigate to the project folder and run either...
dotnet pack

Or (using the Visual Studio Developer Command Prompt)
msbuild /t:pack /p:Configuration=Release