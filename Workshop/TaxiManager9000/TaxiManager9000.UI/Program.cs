// See https://aka.ms/new-console-template for more information
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Exceptions;
using TaxiManager9000.Domain.Utils;
using TaxiManager9000.Services;
using TaxiManager9000.Services.Interfaces;
using TaxiManager9000.Services.Services;
using TaxiManager9000.Services.Services.Interfaces;
using TaxiManager9000.UI.Helpers;
using TaxiManager9000.UI.Utils;

IAuthService authService = new AuthService();
IMaintainanceService maintainanceService = new MaintainanceService();
IAdminService adminService = new AdminService();

StartApplication(authService, adminService, maintainanceService);

Console.ReadLine();

void StartApplication(IAuthService authService, IAdminService adminService, IMaintainanceService maintainanceService)
{
    ShowLogin(authService);
    ShowMenu(authService, adminService, maintainanceService);
}

void ShowMenu(IAuthService authService, IAdminService adminService, IMaintainanceService maintainanceService)
{
    switch (authService.CurrentUser.Role)
    {
        case Role.Administrator:
            ShowAdminMenu(adminService);
            break;
        case Role.Maintainance:
            ShowMaintainenceMenu(maintainanceService);
            break;
        case Role.Manager:
            ShowManagerMenu(authService);
            break;
        default:
            ConsoleUtils.WriteLineInColor($"Invalid role, {authService.CurrentUser.Role}", ConsoleColor.Red);
            break;
    }
}

void ShowAdminMenu(IAdminService adminService)
{
    Console.WriteLine($"{ AdminMenuOptions.ADD_USER}) Create New User: \n {AdminMenuOptions.TERMINATE_USER} Terminate user");
    string input = Console.ReadLine();

    switch (input)
    {
        case AdminMenuOptions.ADD_USER:
            {
                Console.WriteLine("Enter Username");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                Console.WriteLine("Enter role");
                string role = Console.ReadLine();

                adminService.CreateUser(userName, password, role.ToRoleEnum());
                break;
            }
         case AdminMenuOptions.TERMINATE_USER:
            {
                Console.WriteLine("All Users");
                adminService.ListAllUsers().ForEach(x => Console.WriteLine(x.UserName));

                Console.WriteLine("Enter Username");
                string userName = Console.ReadLine();

                adminService.TerminateUser(userName);
                break;
                
            }
        case AdminMenuOptions.CHANGE_USER_PASSWORD:
            {
                Console.WriteLine("Enter Username");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                Console.WriteLine("Enter New Password");
                string newPassword = Console.ReadLine();

                adminService.ChangePassword(userName, password, newPassword);
                break;
            }
        default:
            throw new ArgumentOutOfRangeException("Invalid input");
    }
}

void ShowMaintainenceMenu(IMaintainanceService maintainanceService)
{
    throw new NotImplementedException();
}

void ShowManagerMenu(IAuthService authService)
{
    throw new NotImplementedException();
}

void ShowLogin(IAuthService authService)
{
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter password");
    string password = Console.ReadLine();

    User currentUser;
    try
    {
        authService.LogIn(username, password);

        ConsoleUtils.WriteLineInColor($"Successful login! Welcome {authService.CurrentUser.Role} {authService.CurrentUser.UserName}",
                                      ConsoleColor.Green);
    }
    catch (InvalidCredentialsException ex)
    {
        ConsoleUtils.WriteLineInColor(ex.Message, ConsoleColor.Red); ;
        ConsoleUtils.WriteLineInColor("Unsuccessful login, try again", ConsoleColor.Red);
    }
}