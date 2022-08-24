# Installation Instructions of the Cube Technical Assignment.

- There are 2 folders contained in the root folder.
  - frontend
  - backend
- The front end is an Angular application, while the backend contains a .Net Core 6 application using
  Entity Framework Core as its ORM and PostgreSQL as its database provider.

  ## Configuring the Backend

  ### Database Migration/Setup

  1. Need to install or have an instance of PostgreSQL running. Below are useful links on getting PostgreSQL
     installed for Windows/Mac:
     https://www.postgresqltutorial.com/postgresql-getting-started/install-postgresql-macos/
     https://www.guru99.com/download-install-postgresql.html

  Please make sure PostgreSQL is running.

  2. Open the backend folder, and open the "TemperatureConverterApp.sln" in Visual Studio.

  3. Change the appsettings json connection string in the (1. Presentation Layer) folder to match your database connection of
     the PostgreSQL Server and give it a database name of your choice as we are doing Code First, so it will be created.
     Navigate to the (4. Data Tools) folder of the solution and copy the same connection string details and set the variable
     "dbConnString"

  4. Open a Command Prompt / Terminal on your computer

  5. Use termnal and change directory to ~/DbInstaller, this should be within the Data Tools folder of the solution.
     Using Entity Framework Code First Migrations ( assumes you have the EF Migration tools installed) in the
     Command Prompt-

     - On Windows (Powershell) run: **Update-Database**

     - On Mac run: **dotnet ef database update**

  6. A database matching the name of what was specified in the connection strings will be generated.

  ### Configuration API Launch settings

  1.  The project uses Swagger UI to expose the end point. the launch settings have predefined ip/host addresses. Please update
      to match your IP needs. Please make a note of the path as it will be needed when configuring the Angular App in the next
      section.

  ### Configuring the Front End

  1.  open the front end folder and replace the api endpoint string on **line 16**.
      **temperature-converter/src/app/data/data.service.ts**

## Future Code Improvements

    - 1. Use of error logging
    - 2. Use of Data Mapping libraies for the DTOs e.g AutoMapper
    - 3. Including client side testing of the Angular app
    - 4. Removal of hardcoded connection string in the DbInstaller tool
    - 5. Removal of hardcoded api string in the Angular app
