# WebAPI2BoilerPlate

Boiler plate template for web api implemented in asp.net framework.

## Getting started

### Prerequisites  

 - Visual Studio 2019 or later  
 - .Net Framework (4.7.2)
 - SQL server

 ### Dependancies
#### Nuget Packages
    - EntityFramework 6 (EF6)
    - Microsoft.AspNet.Identity.Owin
    - Serilog
    - Serilog.Settings.AppSettings
    - Serilog.Sinks.File
    - Unity
    - Unity.WebAPI
    - Microsoft.AspNet.Cors
    - Microsoft.Owin.Security.OAuth
    - Microsoft.AspNet.WebApi.Core
    - Microsoft.AspNet.WebApi.Owin
 
 ### Database 
Database Server: SQL server
Database Name: Interview_Test

### Project Architecture
Repository pattern with dependency injection

 - WebAPI2BoilerPlate.API (API endpoints)
 - WebAPI2BoilerPlate.IBusiness (Contains bussiness service interfaces) 
 - WebAPI2BoilerPlate.Business (Contains bussiness service interfaces implementation)
 - WebAPI2BoilerPlate.IRepository (Contains repositories interfaces)
 - WebAPI2BoilerPlate.Repository (Contains repositories interfaces implementation)
 - WebAPI2BoilerPlate.Model (Model classes)
 - WebAPI2BoilerPlate.Data (Database implementation)

## Deployment
### Deployement server
If you have multiple server for the stage and production then specify all the details here

### Deployement prerequistes
If you have EC2 instance or any VPS server then install below prerequistes software in the machine
1. Install IIS
2. Install .Net Framework
### Deployement Steps 
1. Create virtual directory under IIS
2. Enable Inbound and Outbound port for SQL Server(1433) in Firewall(If required)
3. Create security group in your production and stage server if you are using EC2 
4. Update the Database Connection string with Production in web.config
5. Publish your project         
6. Move your publish files to the stage/production server


## License
This project is licensed under the Simform Solutions Pvt. Ltd