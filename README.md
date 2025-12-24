# ICD Internship Project

This repository contains a Windows Forms (.NET 8) application built during my internship at **Industrial Controls and Drive Pvt. Ltd (ICD)**.  
The project demonstrates a basic desktop authentication flow with login, registration, and welcome screens.

## Features

- Login form with username and password fields.
- Registration form for creating new user accounts.
- Welcome screen after successful authentication.
- Uses standard .NET 8 WinForms controls and layout.
- Structured solution with separate forms for Login, Register, and Welcome.

## Tech Stack

- Language: C# (.NET 8)
- UI Framework: Windows Forms
- IDE: Visual Studio 2022
- Libraries:
  - `MySql.Data`
  - `Npgsql`
  - Other .NET 8 runtime dependencies

## Getting Started

1. **Clone the repository**
git clone https://github.com/sreesanth-s02/ICD-Internship-Project.git
cd ICD-Internship-Project

2. **Open in Visual Studio**
- Open `Project1ICD.sln` in Visual Studio 2022.
- Ensure you have .NET 8 SDK installed.

3. **Configure database (if required)**
- Open the code files that handle database connections (for example the main form or a configuration/helper class).
- Update the connection string(s) with your own database credentials.
- Create any required tables in your database before running.

4. **Run the application**
- Set `Project1ICD` as the startup project.
- Press `F5` to build and run.

## Project Structure

- `Project1ICD.sln` – Visual Studio solution file.
- `Project1ICD.csproj` – Project file targeting .NET 8.
- `Form1*.cs` / `Login`, `Register`, `Welcome` related files – WinForms UI and logic.
- `Properties/` – application properties and resources.
- `bin/`, `obj/` – build output folders (ignored by Git).

## Internship Context

This project was developed as part of my internship at **Industrial Controls and Drive Pvt. Ltd (ICD)** to practice building desktop user interfaces, handling authentication flows, and working with .NET 8 WinForms applications.
