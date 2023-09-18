CA Test Demo

Tech Stack

- [x] CA
- [x] NetArchTest

![alt text](./Doc/dotnet-onion-architecture.PNG)

```javascript
$ dotnet new sln -o ca-test-demo

# cd ca-test-demo

$ dotnet new classlib -o Domain

$ dotnet new classlib -o Application

# Application => Domain
$ dotnet add .\Application\ reference .\Domain\

$ dotnet new classlib -o Infrastructure

# Infrastructure => Application
$ dotnet add .\Infrastructure\ reference .\Application\

# dotnet new classlib -o Presentation

# Presentation => Application
$ dotnet add .\Presentation\ reference .\Application\

$ dotnet new webapi -o WebApi

# WebApi => Application
$ dotnet add .\WebApi\ reference .\Presentation\
$ dotnet add .\WebApi\ reference .\Infrastructure\
$ dotnet add .\WebApi\ reference .\Application\

$ dotnet sln add (ls -r **/*.csproj)

$ dotnet add .\Application\ package MediatR
$ dotnet add .\Application\ package Microsoft.Extensions.DependencyInjection.Abstractions
$ dotnet add .\Application\ package FluentValidation
$ dotnet add .\Application\ package FluentValidation.DependencyInjectionExtensions

$ dotnet add .\Infrastructure\ package Microsoft.Extensions.DependencyInjection.Abstractions

$ dotnet add .\WebApi\ package Serilog.AspNetCore

$ dotnet build ca-test-demo.sln

```
