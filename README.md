CRM Project
Overview
This is a simple CRM (Customer Relationship Management) application built with ASP.NET Core. 

It allows you to manage user information, including viewing user lists and individual user details.

Features:
View a list of users
View individual user details
Basic error handling

Project Structure:

Controllers:

HomeController.cs: Manages main pages like index, privacy, and error handling.
UsersController.cs: Handles user-related actions such as listing users and showing user details.

Data:
WebAppContext.cs: Entity Framework Core context for managing the Users entity.
SeedData.cs: Seeds initial data into the database if it's empty.

Models:

Users.cs: Defines the user entity with properties for Id, Name, and Email.

ErrorViewModel.cs: Defines the error model with properties for RequestId and a boolean to show the RequestId.

Getting Started

Prerequisites:
.NET Core SDK 3.1 or later
SQL Server

Setup
Clone the repository:
bash
Copy code
https://github.com/mounikagunji/CRM-project.git
cd crmproject
Configure the database connection in appsettings.json.

Run the application:

bash
Copy code
dotnet run
The database will be automatically seeded with initial data if empty.

Usage
Home page: Main application interface.
/Users: View the list of users.
Click a user’s name to see their details.
Contributing
Contributions are welcome! Fork the repository and submit a pull request for review.

License
Licensed under the MIT License. See the LICENSE file for details.

Acknowledgements
Built with ASP.NET Core and Entity Framework Core.
