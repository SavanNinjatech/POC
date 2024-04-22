# .NET 8 POC Project with Unit of Work Pattern and External API Call

This is a Proof of Concept (PoC) project built using .NET 8 that demonstrates the implementation of the Unit of Work pattern for data access and making external API calls to the Dog API. The project includes a local database connection with Microsoft SQL Server.

## Overview

The project aims to showcase how to:

- Implement the Unit of Work pattern for managing data access and transactions.
- Make external API calls to the Dog API to fetch dog-related data.
- Utilize .NET 8 features and best practices for building scalable and maintainable applications.

## Technologies Used

- .NET 8
- Entity Framework Core
- Microsoft SQL Server
- Dog API (External API)

## Getting Started

To run the project locally, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in your preferred IDE (e.g., Visual Studio 2022).
3. Open the Package Manager Console and run the following command to apply database migrations and create the necessary tables and database:

   ```bash
   Update-Database
4. Run the application with IIS Express.