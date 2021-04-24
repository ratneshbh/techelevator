using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using TenmoClient.Data;

namespace TenmoClient
{
    public class ApiService
    {
        private readonly static string API_BASE_URL = "https://localhost:44315/";
        private readonly IRestClient client = new RestClient();

        //login endpoints
        public bool Register(LoginUser registerUser)
        {
            RestRequest request = new RestRequest(API_BASE_URL + "login/register");
            request.AddJsonBody(registerUser);
            IRestResponse<API_User> response = client.Post<API_User>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("An error occurred communicating with the server.");
                return false;
            }
            else if (!response.IsSuccessful)
            {
                if (!string.IsNullOrWhiteSpace(response.Data.Message))
                {
                    Console.WriteLine("An error message was received: " + response.Data.Message);
                }
                else
                {
                    Console.WriteLine("An error response was received from the server. The status code is " + (int)response.StatusCode);
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        public API_User Login(LoginUser loginUser)
        {
            RestRequest request = new RestRequest(API_BASE_URL + "login");
            request.AddJsonBody(loginUser);
            IRestResponse<API_User> response = client.Post<API_User>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("An error occurred communicating with the server.");
                return null;
            }
            else if (!response.IsSuccessful)
            {
                if (!string.IsNullOrWhiteSpace(response.Data.Message))
                {
                    Console.WriteLine("An error message was received: " + response.Data.Message);
                }
                else
                {
                    Console.WriteLine("An error response was received from the server. The status code is " + (int)response.StatusCode);
                }
                return null;
            }
            else
            {
                client.Authenticator = new JwtAuthenticator(response.Data.Token);
                return response.Data;
            }
        }
        public decimal RequestBalance()
        {
            RestRequest request = new RestRequest(API_BASE_URL + "account");
            IRestResponse<Account> balance = client.Get<Account>(request);
            return balance.Data.Balance;
        }
        public List<Transfer> RequestAllTransfer()
        {
            RestRequest request = new RestRequest(API_BASE_URL + "transfer/all");
            IRestResponse<List<Transfer>> transfers = client.Get<List<Transfer>>(request);
            return transfers.Data;
        }
        public List<User> RequestAllUsers()
        {
            RestRequest request = new RestRequest(API_BASE_URL + "login");
            IRestResponse<List<User>> users = client.Get<List<User>>(request);
            return users.Data;
        }

        public bool TransferFunds(decimal amount, int recipientId)
        {
            SendingTransfer sendingTransfer = new SendingTransfer();
            sendingTransfer.Amount = Convert.ToDecimal(amount);
            sendingTransfer.RecipientId = Convert.ToInt32(recipientId);

            RestRequest request = new RestRequest(API_BASE_URL + "account");
            request.AddJsonBody(sendingTransfer);
            IRestResponse<bool> completed = client.Put<bool>(request);
            return completed.Data;
        }
        public decimal RecordTransfer(decimal amount, int recipientId)
        {
            Transfer newTransfer = new Transfer();
            newTransfer.AccountTo = Convert.ToInt32(recipientId);
            newTransfer.AccountFrom = UserService.GetUserId();
            newTransfer.Amount = Convert.ToDecimal(amount);
            newTransfer.TransferStatusId = 2;
            newTransfer.TransferTypeId = 2;

            RestRequest request = new RestRequest(API_BASE_URL + "transfer");
            request.AddJsonBody(newTransfer);
            IRestResponse<Transfer> transfer = client.Post<Transfer>(request);
            return transfer.Data.Amount;
        }
    }
}
