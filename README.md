# RESTful API with ASP.NET

This project is a simple RESTful API built using ASP.NET Core. It provides basic CRUD (Create, Read, Update, Delete) operations for managing resources and follows REST principles for a clean and scalable API design.

## Features

- **RESTful API Design**: Adheres to REST conventions for easy integration with clients.
- **CRUD Operations**: Basic create, read, update, and delete functionality.
- **Entity Framework Core**: Interacts with the database to persist data.
- **SQL Server**: Used as the backend database for storing and managing resources.

## Requirements

- .NET SDK 7.0 or 8.0
- SQL Server (or SQL Server Express)
- Postman (for testing API endpoints)
- Visual Studio / VS Code

## Getting Started

Follow these steps to set up and run the project locally.

### 1. Clone the Repository

Clone the repository from GitHub:

```bash
git clone https://github.com/abdorhl/Restful-Api-With-ASP.NET.git
cd Restful-Api-With-ASP.NET
```

### 2. Install Dependencies

Ensure that you have .NET 7.0 or higher installed. Then restore the NuGet packages:

```bash
dotnet restore
```

### 3. Configure the Database

Open the `appsettings.json` file and update the connection string with your SQL Server configuration:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your-server;Database=your-database;User Id=your-user;Password=your-password;"
}
```

Apply the database migrations to create the necessary tables:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Running the API

To start the API:

```bash
dotnet run
```

The API will run on `https://localhost:5001` or `http://localhost:5000`.

### 5. API Endpoints

Here are the available API endpoints for managing resources.

#### **Get All Resources**

- **GET** `/api/resources`

Retrieves a list of all resources.

#### **Get Resource by ID**

- **GET** `/api/resources/{id}`

Retrieves a single resource by its ID.

#### **Create Resource**

- **POST** `/api/resources`

Request Body:

```json
{
  "name": "Resource Name",
  "description": "Resource Description"
}
```

Creates a new resource in the database.

#### **Update Resource**

- **PUT** `/api/resources/{id}`

Request Body:

```json
{
  "name": "Updated Resource Name",
  "description": "Updated Resource Description"
}
```

Updates an existing resource by its ID.

#### **Delete Resource**

- **DELETE** `/api/resources/{id}`

Deletes a resource from the database by its ID.

### 6. Testing the API

You can test the API using tools like Postman or cURL. Use the provided endpoints to perform CRUD operations on the resources.

### 7. Project Structure

The API follows a simple architecture:

- **Controllers**: Handle incoming HTTP requests and responses.
- **Services**: Contain business logic for interacting with the database.
- **Models**: Represent the data structure of the resources.
- **Data Access**: Uses Entity Framework Core to interact with the SQL Server database.

## Technologies Used

- **ASP.NET Core**
- **Entity Framework Core**
- **SQL Server**
- **Swagger** (for API documentation)

## License

This project is licensed under the MIT License.

