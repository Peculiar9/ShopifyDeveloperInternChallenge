# Imagier 
### My Entry for the Shopify Developer Intern Challenge

Imagier - Image Repository/ Manager
The Imagier is built on [Microsoft Enterprise Solution Architecture](https://msdn.microsoft.com/en-us/library/ff647095.aspx).  
Specifically using the Layered Architecture Solution Guidance (LASG) . Sample LASG available [here](http://layersample.codeplex.com/).  

## Quickstart

- After Cloning this project on your local or anyother server
- Click on the Solution file of the project, you can easily find it as it has the ".sln" extension.
- Set the "ImagierAPI" as the start up project by right clicking it and selecting the option to make it startup.
- Run the 'dotnet restore' command in terminal of your choice on any OS, or if you have VS19 or later installed 
  if you are connected to the internet that should be sorted automatically, as well as the .NET 5 SDK.
- [Ctrl + F5] to run without debugging.
- [F5] to run with debugging.

## Install

- Install Visual Studio 2019 Community Edition (VS2019) or later [(Download Link)](https://visualstudio.microsoft.com/vs/)
- Or Install VSCode or any IDE of choice and the .NET5 SDK  [(Download Link)](https://dotnet.microsoft.com/download)
- For more help on installation use [(Microsoft Doc Installation Help)](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install)
- Select **.NET SDK** under **.NET 5.0 (recommended)** from the options and click to install.
- Installing missing references
  - The dependencies might be broken but the 'dotnet restore' command should fix it.
  - If not you can reinstall the broken dependencies from [(Nuget Gallery)](https://www.nuget.org/)
  - Add the missing references from within the Solution Explorer.

## Setting up project

- Clone this github repository into a folder
- Launch VS2019 and open solution
- Or if you use Linux OS or you prefer VSCode you can open it up in VSCode so far you have the .NET5 SDK installed
- Run and Build Project "dotnet run" command or use the default debugger for VS19 

## Supported Visual Studio versions

Visual Studio 2019 and later

and Virtually any other IDE

## Contributing

- Check the contribution details for more information.
- The `api` folder contains all the Controller components as well as the DTO models.
- The `Infrastructure` folder the entity models and the services as well as the Data Layer.
