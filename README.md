# dotnetWinformFinalExercise
This is my major assignment for the dotnet programming course class in the second term of Second year learning in Danang University of Science an Technology, which I have accomplished on my own. 

The task requires building a winform application based on the MVC model, with a user interface, basic CRUD functions, and a connection to the database. For this project, I have chosen the topic of managing a pet product store and utilized a database built on SQL Server Management Studio. Additionally, I used the C# programming language and the DevExpress library to develop the interface for this winform application.

The program has the functionality of role-based login, distinguishing between the store manager and store staffs, along with CRUD operations. Store staffs have CRUD permissions for customers and products, while the store manager has additional CRUD permissions for store staffs.

Before running this application, you have to:
1. Download the DevExpress library for winform interface programming. Since this is a paid library, you may need to make a payment, but you can also try the 30-day free trial version.
2. Use the .sql files in the SSMSdatabase folder to create a database for managing the pet product store on your own server.
3. Access the database in Visual Studio, go to the Properties section to copy the connection string of the database, and paste it into the sqlcon variable in the Connection.cs file in the Models folder of the project.
