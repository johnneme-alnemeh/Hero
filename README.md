# Superhero Database API
Project Description
This ASP.NET project provides a RESTful API for managing a superhero database. It supports CRUD (Create, Read, Update, Delete) operations, enabling the addition, retrieval, modification, and removal of superhero records.

The API is built using ASP.NET Core and SQLite (or any other configured database) for persistence. It serves as a backend for applications that require superhero data.

# Features:
# CRUD Operations:
Create new superhero.
Retrieve all superheroes or a specific superhero by ID.
Update superhero details.
Delete superheroes.
Database: Uses PostgreSQL as the default database.
API Endpoints:
Get all superheroes (GET /api/superhero)
Get superhero by ID (GET /api/superhero/{id})
Create superhero (POST /api/superhero)
Update superhero (PUT /api/superhero/{id})
Delete superhero (DELETE /api/superhero/{id})
# Prerequisites:
.NET SDK: Version 9.0.
Database: PostgreSQL is used by default. Configure as needed.
NuGet Package Manager: Required for managing dependencies and database design and needed tools.
