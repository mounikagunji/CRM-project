CRM Project
Overview
This project is a simple CRM (Customer Relationship Management) application built with ASP.NET Core. It provides basic functionality to manage user information, including viewing a list of users and viewing details of individual users.

Features
View a list of users
View details of individual users
Error handling
Structure
Controllers
HomeController.cs: Handles the main pages of the application, such as the index and privacy pages, and error handling.
UsersController.cs: Manages user-related actions, such as displaying the list of users and details of a specific user.
Data
WebAppContext.cs: The Entity Framework Core database context, managing the Users entity.
SeedData.cs: Seeds the database with initial data if the database is empty.
Models
Users.cs: Represents the user entity with properties for Id, Name, and Email.
ErrorViewModel.cs: Represents the error model with properties for RequestId and a boolean indicating whether to show the RequestId.

Getting Started
Prerequisites
.NET Core SDK 3.1 or later
SQL Server
Setup
Clone the repository:

bash
Copy code
git clone https://github.com/yourusername/crmproject.git
cd crmproject
Set up the database:

Ensure your database connection string is set correctly in appsettings.json.

Run the application:

bash
Copy code
dotnet run
Seed the database:

The database will be seeded with initial data if it's empty when the application starts.

Usage
Navigate to the home page to see the main application.
Go to /Users to see the list of users.
Click on a user's name to see details about that user.
Contributing
Contributions are welcome! Please fork this repository and submit a pull request for review.

License
This project is licensed under the MIT License. See the LICENSE file for details.

Acknowledgements
This project was created using ASP.NET Core and Entity Framework Core.
