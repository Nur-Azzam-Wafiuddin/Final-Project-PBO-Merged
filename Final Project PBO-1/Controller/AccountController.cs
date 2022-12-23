using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_PBO_1.Model;
using RestSharp;
using System.Security.Principal;

namespace Final_Project_PBO_1.Controller
{
    internal class AccountController
    {
        public string accountUrl = "http://localhost:7100/api/Account/";
        public void PostAccount(string name, string username, string password)
        {
            SendAccount SignUpData = new SendAccount();

            SignUpData.name = name;
            SignUpData.username = username;
            SignUpData.password = password;
            SignUpData.productHistory = new List<ProductHistory>() { };

            var SignUpDataJson = JsonConvert.SerializeObject(SignUpData);

            var postUrl = accountUrl;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/xml");
            request.AddJsonBody(SignUpDataJson);

            var response = client.Post(request);
        }

        public List<Account> GetAllAccount()
        {
            var postUrl = accountUrl;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Get(request);
            List<Account> accountList = JsonConvert.DeserializeObject<List<Account>>(response.Content);
            return accountList;
        }

        public Account GetAccountById(int id)
        {
            var postUrl = accountUrl + id;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Get(request);
            Account foundAcc = JsonConvert.DeserializeObject<Account>(response.Content);
            return foundAcc;
        }

        public void EditAccountById(Account editAcc, int id)
        {
            var EditedAccJson = JsonConvert.SerializeObject(editAcc);

            var postUrl = accountUrl + id;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/xml");
            request.AddJsonBody(EditedAccJson);

            var response = client.Put(request);
        }

        public void DeleteAccountById(int id)
        {
            var postUrl = accountUrl + id;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Delete(request);
        }

    }
}