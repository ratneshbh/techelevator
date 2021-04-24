using RestSharp;
using System;
using System.Collections.Generic;
using TenmoClient.Data;

namespace TenmoClient
{
    class Program
    {
        static readonly string API_URL = "https://localhost:44315/";
        static readonly RestClient client = new RestClient(); 
        private static readonly ConsoleService consoleService = new ConsoleService();
        private static readonly ApiService apiService = new ApiService();

        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            int loginRegister = -1;
            while (loginRegister != 1 && loginRegister != 2)
            {
                Console.WriteLine("Welcome to TEnmo!");
                Console.WriteLine("1: Login");
                Console.WriteLine("2: Register");
                Console.Write("Please choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out loginRegister))
                {
                    Console.WriteLine("Invalid input. Please enter only a number.");
                }
                else if (loginRegister == 1)
                {
                    while (!UserService.IsLoggedIn()) //will keep looping until user is logged in
                    {
                        LoginUser loginUser = consoleService.PromptForLogin();
                        API_User user = apiService.Login(loginUser);
                        if (user != null)
                        {
                            UserService.SetLogin(user);
                        }
                    }
                }
                else if (loginRegister == 2)
                {
                    bool isRegistered = false;
                    while (!isRegistered) //will keep looping until user is registered
                    {
                        LoginUser registerUser = consoleService.PromptForLogin();
                        isRegistered = apiService.Register(registerUser);
                        if (isRegistered)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Registration successful. You can now log in.");
                            loginRegister = -1; //reset outer loop to allow choice for login
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }

            MenuSelection();
        }

        private static void MenuSelection()
        {
            int menuSelection = -1;
            while (menuSelection != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to TEnmo! Please make a selection: ");
                Console.WriteLine("1: View your current balance");
                Console.WriteLine("2: View your past transfers");
                Console.WriteLine("3: View your pending requests");
                Console.WriteLine("4: Send TE bucks");
                Console.WriteLine("5: Request TE bucks");
                Console.WriteLine("6: Log in as different user");
                Console.WriteLine("0: Exit");
                Console.WriteLine("---------");
                Console.Write("Please choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    Console.WriteLine("Invalid input. Please enter only a number.");
                }
                else if (menuSelection == 1)
                {
                    decimal balance = apiService.RequestBalance();
                    Console.WriteLine($"Your balance is {balance}");
                }
                else if (menuSelection == 2)
                {
                    List<Transfer> transfers = apiService.RequestAllTransfer();
                    PrintTransfers(transfers);
                }
                else if (menuSelection == 3)
                {

                }
                else if (menuSelection == 4)
                {
                    List<User> users = apiService.RequestAllUsers();
                    PrintUsers(users);

                    Console.WriteLine("Enter user id you want to send funds to");
                    string recipientId = Console.ReadLine();
                    Console.WriteLine("How much do you want to send");
                    string amount = Console.ReadLine();
                    int recipientIdInt = Convert.ToInt32(recipientId);
                    decimal amountDecimal = Convert.ToInt32(amount);
                    bool isSuccessful= apiService.TransferFunds(amountDecimal, recipientIdInt);
                    if (isSuccessful)
                    {
                        decimal amountTransfered = apiService.RecordTransfer(amountDecimal, recipientIdInt);
                        Console.WriteLine($"Sent {amountTransfered}");
                    }
                    else
                    {
                        Console.WriteLine("Transfer not successful");
                    }   
                }
                else if (menuSelection == 5)
                {

                }
                else if (menuSelection == 6)
                {
                    Console.WriteLine("");
                    UserService.SetLogin(new API_User()); //wipe out previous login info
                    Run(); //return to entry point
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
            }
        }
        private static void PrintTransfers(List<Transfer> transfers)
        {
            if (transfers == null)
            {
                Console.WriteLine("No transfers have been made yet");
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Transfers");
                Console.WriteLine("-----------------------------------------------------");
                foreach (Transfer transfer in transfers)
                {
                    Console.WriteLine($"Transfer ID = {transfer.TransferId}, Transfer Type Id = {transfer.TransferTypeId}, Transfer Status Id = {transfer.TransferStatusId}, Account From = {transfer.AccountFrom}, Account To = {transfer.AccountTo}, Amount Transferred = {transfer.Amount}");
                }
            }
        }
        private static void PrintUsers(List<User> users)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("users");
            Console.WriteLine("-----------------------------------------------------");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.UserId}:{user.Username}");
            }
        }
    }
}
