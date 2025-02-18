# User Management App

**User Management App** is a simple desktop application designed for managing user data, including user authentication, registration, and role-based access control. The app enables administrators and employees to manage users securely, with different access levels based on user roles.

## Features

- **User Authentication**: Secure login system that validates usernames and passwords.
- **Role-Based Access Control**:
  - **Admin**: Full CRUD (Create, Read, Update, Delete) access. Admins can manage both Admins and Employees. Admins also have the ability to **search** and **filter** the list of users.
  - **Employee**: Limited access. Employees can **only add new employees** and **view the employee list**, but cannot manage Admin users.
- **Password Visibility Toggle**: Allows toggling the visibility of the password for convenience during login.
- **First-time Setup**: Automatically creates an admin account when the app is used for the first time.
- **Simple UI**: The interface is simple and easy to use.
- **Database Management**: Admins can manage users and roles, while Employees have limited permissions.

## Technologies Used

- **C#**: The primary programming language for implementing the app’s functionality.
- **ADO.NET**: Used for connecting to and interacting with the SQL database.
- **Windows Forms**: The UI framework for building the application interface.
- **SQL**: Database system used for storing and managing user data.

## Tools

- **Visual Studio 2022**: The Integrated Development Environment (IDE) used to develop the app.
- **SQL Server 2019**: Database server for storing user data.
- **SQL Server Management Studio 18**: Tool for managing the SQL Server and running scripts.

## Project Structure

- **DAL (Data Access Layer)**: Contains the database connection logic and methods for executing SQL queries.
- **BL (Business Logic Layer)**: Contains the core business logic and classes.
- **PL (Presentation Layer)**: Contains forms and UI components for the application interface.
- **Resources**: Folder containing images and icons used throughout the app.

## Database Setup

The project includes the necessary database script and database files (`.mdf` and `.ldf`). You can easily set up the database by either running the provided SQL script or attaching the database files to SQL Server.

### Option 1: Attaching the Database Files

1. **Unzip DB Files.zip**
    - Unzip the file named `"DB Files.zip"` and you can find it in the `database files` folder.

2. **Copy the Database Files**: 
   - Locate the `UserTestDB.mdf` and `UserTestDB.ldf` files in the project directory.

3. **Move the files** to the following directory on your system:
   ```plaintext
   C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA
4. **Configure the Connection String:**
    - In the DataAccessLayer class (located in the DAL folder), you'll need to update the connection string with the name of your SQL Server instance.
### Option 2: Running the Database Script

1. **Open SQL Server Management Studio (SSMS).**

2. **Run the Database Script:**
    - Execute the provided SQL script to:
        - Create the database.
        - Use this database.
        - Create the table.
        - Create stored procedures.

## Prerequisites

- .NET Framework 4.8: This application requires .NET Framework 4.8. Make sure you have it installed on your machine before running the app.

- Visual Studio 2022: The recommended IDE for building and running the application.

- SQL Server 2019: Required for storing the user data.

## Getting Started

### To run the app locally, follow these steps:

1. **Clone the repository:** 

   ```plaintext
   git clone https://github.com/Ayoub-Outrgua/User-Management-App
2. **Open the project in Visual Studio.**

3. **Set Up the Database:**
    - Attach the .mdf and .ldf database files to SQL Server, or run the provided CreateDatabase.sql script.

4. **Build and Run the Application.**

5. **Test the App** by logging in with the default admin credentials (Username: Admin, Password: Admin), or by adding new users from the app.
