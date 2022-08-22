# Commands For Database Migrations

## Ensure Open a console window and point to the folder DBInstaller
## Ensure the DBInstaller is the default Debug project

# NOTE: CSContextFactory.cs has the connection string that is used for the migration
#     You can change this in the C# ( i know its not ideal, but could be safe in some scenarios :/ )


# Run the appropriate command in the console:

dotnet ef migrations add <MANE OF THE MIGRATION>

dotnet ef database update

dotnet ef migrations remove

