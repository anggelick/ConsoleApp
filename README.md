# ConsoleApp README

This repository contains a .NET Console Application built with C# and Entity Framework Core using a Code-First approach. The application interacts with a Microsoft SQL Server database to perform CRUD operations on customer data.

## Project Structure

- **ConsoleApp**: Main project folder containing the .NET Console Application.
- **Data**: Folder containing the local SQL Server database file (`local_db.mdf`).
- **ConsoleApp.Tests**: Placeholder for any future unit tests.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed
- [Visual Studio](https://visualstudio.microsoft.com/) or any preferred code editor

### Running the Application

1. Open the project in Visual Studio or your preferred code editor.

2. Update the connection string in `AppDbContext.cs` to point to the correct location of your database file.

3. Build and run the application.

## Database

- The application uses Entity Framework Core and Code-First migrations to manage the database schema.
- The `AppDbContext.cs` file contains the database context configuration.
- The `Migrations` folder stores migration files.

## Project Usage

- The main entry point is `Program.cs`, where a sample usage of the `CustomerService` is demonstrated.

## Issues and Troubleshooting

- If you encounter any issues related to the database, ensure that the database file and path are correctly configured.

## Contributing

Pull requests and contributions are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
