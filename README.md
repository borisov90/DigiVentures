# DigiVentures
 Overview for the other team from Sportal Media Group

Small project done according to the following task: https://gist.github.com/kostadinstoilov/51634f3a5a01d3a7694617b6cc67eea7

Technologies used: 
Frontend/Backedn : ASP.NET Core v. 2.1.2
Entity Framework Core v.2.1.2
Entity Framework Core SqlServer 2.1.2
DataTables for jQuery /https://datatables.net//

Project is written on Visual Studio 2017 and consists of a ASP.NET MVC project and a local SQL database. 
Data Access Layer is in the Digital.Ventures.Data class library. 
Code First approach was used with Entity Framework to generate the database and seed some initial players in it.

Before running the project a "Update-Database -verbose" command should be run in the Package Manager Console in order for the DB to be created. 
If you are not using Visual Studio the following command - dotnet run - should run the project on any environment (that is if you are in the project folder).
If you have troubles with starting the project, here is help: https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run

