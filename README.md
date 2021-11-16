# Welcome to my custom C# .Net Core template!

[Github repo](https://github.com/T1M0UT/TemplateProjects)

## How does it look like?
- #### .Net Core 6.0
<<<<<<< HEAD
![.Net 6.0 View](https://github.com/T1M0UT/TemplateProjects/Images/blob/main/ApplicationViewNet6.png)
=======
![.Net 6.0 View](https://github.com/T1M0UT/TemplateProjects/blob/main/ApplicationViewNet6.png)
>>>>>>> 7ed9ee4a43f2ec89b2f645adc360591eca8d056f
- #### .Net Core 5.0
![.Net 5.0 View](https://github.com/T1M0UT/TemplateProjects/Images/blob/main/ApplicationViewNet5.png)
## Why would you need this?

- Default net6.0 console app template is too short
- You don't get extra "Hello World" or what so ever
- To enjoy C# 10 features with a classic-style template


## Installation

If you use Visual Studio or Rider
open NuGet Package Manager
and than find KrasnianskiyConsoleTemplate:
![.Net 5.0 View](https://github.com/T1M0UT/TemplateProjects/Images/blob/main/NuGet.png)

#### or

Use the terminal in your IDE or the default one, and type:

```sh
dotnet new --install KrasnianskiyConsoleTemplate::1.1.1
```

## Creating a new project

1. Open terminal in your IDE or the built-in one in the target directory
2. Type:
```sh
dotnet new krasnianskiyconsole -o "NAME_OF_YOUR_PROJECT"
```
3. Open your new solution:
```sh
open NAME_OF_YOUR_PROJECT/NAME_OF_YOUR_PROJECT.sln
```
#### or
Use your IDE to create a new project and this custom one will appear automaticaly in "other templates"

And there you go!

## Additional arguments
#### *Too see the whole list type:*

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
