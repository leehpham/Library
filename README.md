# Library Web App
## Install List
- Visual Studio 2017 Community Edition
	- .NET Core cross-platform Development
	- ASP.NET and web development
	- Data Storage and Processing (SQL Server)
- SQL Server Express Edition
	- Ensure MSSqlLocalDb is installed and working
		- sqllocaldb
			- should return a list of possible commands from the command line.
- SQL Server Management Studio (hmm...)

## Framework
- .NET Core 1.1
- Microsoft.EntityFrameworkCore 1.1.2
	- Installed to LibraryData and Library
	- ORM for mapping data from entity models (C# objects) to SQL database (Mycrosoft SQL)
	- Code First:
		- We'll write domain classes first in C# and allow the framework to create and manage changes to the database,
		rather than designing a database and having the ORM auto-generate our entities.
- Microsoft.EntityFrameworkCore.SqlServer 1.1.2 (could replace this by MySQL)
	- Installed to LibraryData and Library
- Microsoft.EntityFrameworkCore.Tools 1.1.1
	- Installed to LibraryData
	- This allows us to use the Package Manager console to do database migration.
- Front-end:
	- Material Design Lite
	- Bootstrap 3.3.7
	- Google Font: Coda

## Project Structure
- LibraryData: (Class Library) 
	- This is where I implement Entity Framework Core.

## Database Migrations
- Helps us keep changes to our database schema organized and reversible.
- Step 1
	- add-migration "InitialMigration"
- Step 2
	- update-database

## Table-Per-Hierarchy (TPH)
- Inheritance Strategy: One table for all entity types in an inheritance hierarchy.
