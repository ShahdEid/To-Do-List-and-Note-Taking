# To-Do-List-and-Note-Taking
Application Overview
The application is a to-do list and note-taking tool designed to streamline task management and note organization. Users can add tasks with a title and description, mark them as complete, and edit or delete them as needed. Similarly, the note-taking feature offers the functionality to create, edit, or remove notes. Both components are seamlessly integrated with the local database, ensuring that any additions, modifications, or deletions by the user are effectively captured and persisted in the database. Regardless of the user's selection, previously entered data is readily accessible, illustrating the application's capacity to preserve historical user interactions. The application is designed with consistency, standardized design elements like fonts, buttons, and layouts enhancing the user experience. By placing these elements in familiar positions, the application effectively reduces the learning curve for users.

Application Usage Instructions
1. Download and Setup
Download the Zip File.
Extract the file and place it in the desired location on your machine.
Open the .sln file.
2. Loading Solution
It might take a few moments for the solution to load.
Click on the View and choose the Server Explorer.
3. Connect to Database
Choose the "Connect to Database" option.
Ensure that the Data source is set to Microsoft SQL Server Database File.
Click OK and Browse for the Database File Name.
Choose the TodoListApp, you will find LocalDatabase.mdf in the file path where the application has been extracted.
Note: You might be asked to upgrade the database file depending on the compatibility between the database file version and the SQL server instance that Visual Studio is configured to use.
4. Configuration
You will find the local database connected now in the Server Explorer.
Open the App.config File found in the Solution Explorer.
Go back to the Server Explorer and right-click the LocalDatabase.mdf and choose Properties.
Copy the LocalDatabase’s Connection string.
Once you copy the new connection string from the Server Explorer, replace the entire connection string within the <connectionStrings> section of your App.config file.
Note: After pasting the connection string into the App.config file, please verify that no extraneous quotation marks have been included. These can sometimes occur depending on the version of Visual Studio used and may lead to syntax errors during application startup.
5. Start the Application
Save and start the project by clicking the Start button or F5.
User Login Credentials:
After starting the application, a login form will pop up, please enter the following to login:
Username: User1
Password: User@le1
Additional Information
The programming language used to develop this application is C#. C# is a very versatile programming language favored for its robustness and object-oriented capabilities.
The Windows Forms Framework was used which is part of the .NET Framework, allowing for the design of the graphical user interface (GUI) applications.
