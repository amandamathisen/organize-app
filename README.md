# Organize App

A full-stack todo application built with modern technologies. Manage your tasks efficiently with a clean, intuitive interface and a robust backend API.

## Features

- Create, read, and manage todo items
- Mark tasks as completed
- Persistent storage with SQLite database
- RESTful API backend
- Responsive frontend interface

## ech Stack

### Frontend

- **React** 19.2 - UI library
- **TypeScript** - Type-safe JavaScript
- **Vite** - Fast build tool and dev server
- **ESLint** - Code quality and style

### Backend

- **.NET** (C#) - Web framework
- **Entity Framework Core** - ORM
- **SQLite** - Database
- **ASP.NET Core** - API framework

## Project Structure

```
organize-app/
├── Organize-frontend/    # React frontend application
│   ├── src/
│   │   ├── App.tsx      # Main app component
│   │   └── main.tsx     # Entry point
│   └── package.json
├── OrganizeApi/          # .NET backend API
│   ├── Controllers/      # API endpoints
│   ├── Models/           # Data models
│   ├── Data/             # Database context
│   └── Program.cs        # App configuration
└── README.md
```

## Getting Started

### Prerequisites

- **Node.js** (16+) and npm - for frontend
- **.NET SDk** (10.0+) - for backend

### Frontend Setup

1. Navigate to the frontend directory:

   ```bash
   cd Organize-frontend
   ```

2. Install dependencies:

   ```bash
   npm install
   ```

3. Start the development server:

   ```bash
   npm run dev
   ```

4. Build for production:
   ```bash
   npm run build
   ```

### Backend Setup

1. Navigate to the API directory:

   ```bash
   cd OrganizeApi
   ```

2. Build the project:

   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

The API will be available at `http://localhost:5000` (or the configured port).

## API Endpoints

### Todos

- **GET** `/api/todos` - Retrieve all todos
- **POST** `/api/todos` - Create a new todo

Example request body:

```json
{
  "title": "Buy groceries",
  "isCompleted": false
}
```

## Database

The application uses SQLite database (`organize.db`) for persistent storage. The database is automatically created when the application runs for the first time.

### Models

- **ToDo** - Contains `Id`, `Title`, and `IsCompleted` properties

## Development

### Code Quality

- Run ESLint on frontend:
  ```bash
  npm run lint
  ```

### Project Files

- Frontend configuration: `tsconfig.json`, `vite.config.ts`, `eslint.config.js`
- Backend configuration: `appsettings.json`, `OrganizeApi.csproj`
