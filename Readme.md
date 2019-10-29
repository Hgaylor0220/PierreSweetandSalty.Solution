# Pierre's Sweet and Salty

User will be able to log in and order treats based on if they are sweet, salty or both or more!. 

## Authors

Hailey Gaylor, Haileygaylor@gmail.com

## Use
User can customize thier preference on the treats thy are looking for based on their taste.
## Set-Up

- run 'git clone https://github.com/Hgaylor0220/PierreSweetandSalty.Solution.git' in terminal to copy directory
- navigate to project directory 'PierreSweetandSalty.Solution' and run $dotnet restore.
- Run in the terminal $dotnet run watch

## Setting up new DB
- Navigate to the SalonManagementSystem folder in the project
- In the terminal run the command $ dotnet ef migrations add NewDB. This will make file message of your new database.
- run the command $dotnet ef database update. This will add your new updated Database
- run the command $dotnet run watch To start the application 

## Specs

| Scenario | When | given that | Result |
|-|-|-|-|
| User creates an account | User selects  Register/sign in|  User will enter their email and password and confirm password| Account will be created and return user to home or log out |
|  User creates a Treat| User selects " logged in? Create a Treat| User is logged in and all paths return correctly  | Bring user to the add/ view treats page |
| User can create or edit a flavor |User selects "Logged in? Create a flavor or view flavors | User is logged in and all paths return correctly | Bring user to the home page to create or edit a flavor |


## Technologies

C#, EntityFramework, .NET, MySQL Lite, VS Code, .cshtml;

## License

Open source, 2019 (MIT)