# DinkToPdfAll
.NET Standard library which wrapping the [DinkToPdf](https://github.com/rdvojmoc/DinkToPdf) library that include x64 and x86 version of the wkhtmltox library.

## Install
This library is available in [NuGet](https://www.nuget.org/packages/DinkToPdfAll/).  
At nuget package manager, run the follow command.
```
PM> IInstall-Package DinkToPdfAll 
```
At .NET CLI console, run the follow command. 
```
dotnet add package DinkToPdfAll
```

## How to load wkhtmltox library?
You must call the Load method in ConfigurateService at Startup.
```csharp
 DinkToPdfAll.LibraryLoader.Load();
```
## How to use it?
Please read the official documentation of [DinkToPdf](https://github.com/rdvojmoc/DinkToPdf).
