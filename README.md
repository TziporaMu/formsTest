This application mimics the Public Complaints page of the Israeli Judiciary Authority. The goal is to recreate this page with a modern frontend using Angular and a backend built on .NET 9.

Backend: .NET 9
Prerequisites
Ensure you have the following software installed on your machine before setting up the backend:

.NET 9 SDK: You can download it from here.
SQL Server: For managing the database (you can use SQL Server Express or another version of SQL Server).
Setup Instructions
Clone the Repository:

First, clone the repository to your local machine:

bash
Copy code
git clone https://github.com/TziporaMu/publicInquiriesApi.git
Navigate to the Backend Folder:

Change the directory to the backend folder:

bash
Copy code
cd backend
Restore Dependencies:

Use the .NET CLI to restore the required NuGet packages:

bash
Copy code
dotnet restore
Configure Database Connection:

Open the appsettings.json file and configure the connection string for SQL Server:


Replace your_password with your actual SQL Server password.

Apply Database Migrations:

Run the Entity Framework migrations to set up the database schema:

bash
Copy code
dotnet ef database update
Run the Backend:

To run the backend, use the following command:

bash
Copy code
dotnet run
The backend API will be accessible at http://localhost:7094.
