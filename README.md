# .NET-LAB

## 1 Setup .NET SDK

1. **Download the .NET SDK**:
   Download the latest .NET SDK from the following link:
   [Download .NET SDK](https://download.visualstudio.microsoft.com/download/pr/d1adccfa-62de-4306-9410-178eafb4eeeb/48e3746867707de33ef01036f6afc2c6/dotnet-sdk-8.0.303-win-x64.exe)

2. **Check the Installed Version**:
   After installation, open PowerShell or Command Prompt and verify the .NET SDK version:
   ```sh
   dotnet --version


## 2 .Navigate to your desired directory and create a new project:

dotnet new console -n MyFolder      

cd MyFolder

 

 ## 3 .Build and Run the Project:

 dotnet build 

[ code . ] command directy open the myFolder in the vscode 

 dotnet run


 # To run in vs code

 ## - Add path temporarly in vs code terminal
 $env:PATH += ";C:\Program Files\dotnet"

 Check Dotnet Version:

 dotnet --version
 ### - Do steps 2 and 3 except [code .] command

## After lab 12

### Create new folder using mvc

dotnet new mvc -n myFolder

cd myFolder


## Lab 13 DBContexxt

### Before you start, make sure you have the necessary NuGet packages installed. You can add these packages using the .NET CLI:

dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Microsoft.EntityFrameworkCore.Tools

###  Running the Application

#### Create the Database:

dotnet ef migrations add InitialCreate

dotnet ef database update

#### Run the application:

dotnet run

## CRUD LAB

### Install the required package

dotnet add package Microsoft.Data.Sqlite


dotnet build 

dotnet run










