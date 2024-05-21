# Product Microservice using ASP.NET Core

This project provides a step-by-step guide on how to develop a Product microservice using ASP.NET Core. The microservice is constructed using ASP.NET Core 2.1 and Visual Studio 2017 or later versions, with built-in support for ASP.NET Core. The microservice includes its own DBcontext and database, as well as an isolated repository, allowing for independent deployment of the service.

## Project Overview

### Background

This project aims to create a Product microservice using ASP.NET Core, which includes functionalities for managing products and categories.

## Tasks

### Creating an ASP.NET Core Application Solution

1. Open Visual Studio and add a new project.
2. Choose the application as ASP.NET Core Web Application and enable Docker support with the OS type as Linux.
3. The solution will include the necessary project structure for an ASP.NET Core API application.

### Adding Models

5. Add a `Model` folder to the project.
6. In the `Models` folder, add a class named `Product` with properties like Id, Name, Description, Price, and CategoryId.
7. Similarly, add a `Category` model with properties like Id, Name, Description, and Price.

### Enabling EF Core

9. Add a `DBContexts` folder to the project.
10. Add a `ProductContext` class with DbSet properties for Products and Categories, and seed sample categories in the OnModelCreating method.
10.1 Add a connection string in the `appsettings.json` file.

### Adding Repository

11. Add a `Repository` folder in the project and define an `IProductRepository` interface for CRUD operations.
12. Implement the `ProductRepository` class that implements `IProductRepository` and interacts with the `ProductContext`.

### Adding Controller

15. Add a `ProductController` class with GET, POST, PUT, and DELETE methods for managing products.
19. Implement the methods by calling the repository methods.

### Entity Framework Core Migrations

21. Open Package Manager Console and execute commands for migrations and updating the database.

### Run the Product Microservice

26. Add container orchestrator support in the solution.
31. Run the application with Docker as an option.

## Author

**Tertius Denis Liebenberg**  

For any questions or feedback, please contact [tertiusliebenberg7@gmail.com].