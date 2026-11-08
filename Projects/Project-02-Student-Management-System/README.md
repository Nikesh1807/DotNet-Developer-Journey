# Student Management System

A console-based Student Management System developed using C# and .NET. This project helps manage student records through basic CRUD operations and stores data persistently using JSON file handling.

## Features

- Add new student records
- View all students
- Search students by ID
- Update student details
- Delete student records
- Search students by course
- Calculate average marks
- Input validation
- Prevent duplicate student IDs
- Store and load records using JSON serialization

## Technologies Used

- C#
- .NET
- Object-Oriented Programming (OOP)
- Collections (`List<T>`)
- LINQ
- File Handling
- JSON Serialization and Deserialization

## Project Structure

```text
StudentManagementSystem/
│
├── Data/
│   └── students.json
│
├── Models/
│   └── Student.cs
│
├── Services/
│   └── StudentServices.cs
│
├── Program.cs
├── StudentManagementSystem.csproj
└── README.md
```

## How to Run

1. Clone this repository.
2. Open the project folder in VS Code.
3. Open the terminal.
4. Run the following command:

```bash
dotnet restore
dotnet run
```

## Learning Objectives

This project was built to apply C# fundamentals practically, including OOP, collections, LINQ, exception handling, file handling, and JSON serialization.

## Future Improvements

- Improve input validation and error handling
- Add a graphical user interface
- Integrate a database such as SQL Server