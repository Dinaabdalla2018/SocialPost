Welcome to the readme file for the Windows Form Desktop Social Post project using Entity Framework, Code First, LINQ, and Migration!

## Project Description
The Windows Form Desktop Social Post project is a simple social media application that allows users to create and view posts. The application is built using Windows Forms and utilizes Entity Framework with Code First approach for data access. LINQ is used for querying the database and Migration is used for managing database changes.

## Prerequisites
- Visual Studio 2020
- .NET Framework 4.7.2 or later
- SQL Server Management Studio or LocalDB

## Getting Started
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Restore NuGet packages by right-clicking on the solution in Solution Explorer and selecting "Restore NuGet Packages".
4. Modify the connection string in `app.config` to point to your local SQL Server or LocalDB instance.
5. Open the Package Manager Console in Visual Studio by selecting "Tools" > "NuGet Package Manager" > "Package Manager Console".
6. Run the following command in the Package Manager Console to create the database:

```
Update-Database
```

7. Build and run the project. You should see the login form of the application.

## Project Structure
- `Models/`: Contains the entity models for the application and the DbContext and database configuration files.
- `Forms/`: Contains theforms for the application, including the login form and the main form.
- `Properties/`: Contains project properties and settings.
- `migrations`: Contains the version history of the database changes made using Entity Framework's Code First approach.
- `Program.cs`: Contains the application startup code.

## Technologies Used
- Windows Forms: A graphical user interface (GUI) framework for creating desktop applications on Windows.
- Entity Framework: An object-relational mapper (ORM) that enables .NET developers to work with relational data using domain-specific objects.
- LINQ: A language-integrated query technology that provides a unified query syntax to query data from different data sources.
- Migration: A feature in Entity Framework that enables developers to manage database changes over time using code-based migrations.

## forms
![Screenshot](screen shot/Sinup.png)

## Contributing
If you find any issues or bugs, please feel free to open an issue or submit a pull request. We welcome contributions and feedback from the community.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.
