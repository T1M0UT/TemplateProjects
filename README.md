# Welcome to my custom C# .Net Core template!

[Github repo](https://github.com/T1M0UT/TemplateProjects)

## Why would you need this?

- Default net6.0 console app template is too short
- You don't get extra "Hello World" or what so ever


## Installation

If you use Visual Studio or Rider
open NuGet Package Manager
and than find KrasnianskiyConsoleTemplate

### or

Use the terminal in your IDE or the default one, and type:

```sh
dotnet new --install KrasnianskiyConsoleTemplate::1.1.1
```

## Creating a new project

1. Open terminal in your IDE or in the built-in one in the target directory
2. Type:
```sh
dotnet new krasnianskiyconsole -o "NAME_OF_YOUR_PROJECT"
```
3. Open your new solution:
```sh
open NAME_OF_YOUR_PROJECT/NAME_OF_YOUR_PROJECT.sln
```
And there you go!

## Additional arguments
##### *Too see the whole list type:*

```sh
dotnet new krasnianskiyconsole --help
```
- #### .Net Core version
```
Options:                                              
  -F|--Framework  The target framework for the project
                      net6.0                          
                      net5.0                          
                  Default: net5.0         
```

_Made by Tymur Krasnianskiy_