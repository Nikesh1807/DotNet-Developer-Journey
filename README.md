# .NET Developer Journey

Welcome to my personal C# and .NET learning repository.

This repository is organised into two main sections:

1. **CodePractice** – topic-wise learning notes, examples and coding exercises, organised by learning parts.
2. **Projects** – complete applications built while applying the concepts I learn.

The goal is to strengthen my programming fundamentals, practise consistently, and gradually build real-world .NET applications.

## Repository structure

```text
DotNet-Developer-Journey/
├── CodePractice/
│   ├── Part-01-CSharp-Fundamentals/
│   ├── Part-02-OOP/
│   ├── Part-03-Core-CSharp/
│   └── Part-04-...
│
└── Projects/
    ├── Project-01-Student-Management-System/
    ├── Project-02-...
    └── ...
```

## Learning roadmap

| Part | Topics | Status |
|---|---|---|
| Part 1 | C# Fundamentals – Microsoft Learn | Completed |
| Part 2 | OOP Concepts and related topics | Completed |
| Part 3 | Collections, Generics, File Handling, JSON Serialization and LINQ | Learned / practice ongoing |
| Part 4 | Exception Handling, Debugging and Clean Code | Planned |
| Part 5 | SQL Server and Database Fundamentals | Planned |
| Part 6 | ADO.NET and Entity Framework Core | Planned |
| Part 7 | ASP.NET Core Web API | Planned |
| Part 8 | Dependency Injection, Authentication and Validation | Planned |
| Part 9 | Deployment and advanced .NET development | Planned |

## How to run a practice part

For example:

```bash
dotnet run --project CodePractice/Part-03-Core-CSharp/Part-03-Core-CSharp.csproj
```

## How to run a project

Each project will have its own folder and `.csproj` file. Follow the instructions in that project's README.

## Git workflow

After practising a topic or completing a project:

```bash
git add .
git commit -m "Add Part 3 LINQ practice"
git push
```

Keep commits small and use messages that describe the actual work.
