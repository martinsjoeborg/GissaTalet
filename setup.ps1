# Create the solution
dotnet new sln -n GissaTaletSolution


# Create the core library project (for game logic)
dotnet new classlib -n GissaTalet.Core
# Verkare inte behövas --> dotnet add GissaTalet.Core package System.Collections.Immutable


# Create the console application project
dotnet new console -n GissaTalet.ConsoleApp


# Create the test project using xUnit
dotnet new xunit -n GissaTalet.Tests
dotnet add GissaTalet.Tests package Shouldly


# Add project references
dotnet add GissaTalet.ConsoleApp reference GissaTalet.Core
dotnet add GissaTalet.Tests reference GissaTalet.Core


# Add the projects to the solution
dotnet sln GissaTaletSolution.sln add GissaTalet.Core/GissaTalet.Core.csproj
dotnet sln GissaTaletSolution.sln add GissaTalet.ConsoleApp/GissaTalet.ConsoleApp.csproj
dotnet sln GissaTaletSolution.sln add GissaTalet.Tests/GissaTalet.Tests.csproj
