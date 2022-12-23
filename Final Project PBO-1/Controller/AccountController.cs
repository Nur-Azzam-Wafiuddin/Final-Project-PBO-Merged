using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_PBO_1.Model;
using RestSharp;

namespace Final_Project_PBO_1.Controller
{
    internal class AccountController
    {
        public void PostAccount(string name, string username, string password)
        {
            SendAccount SignUpData = new SendAccount();

            SignUpData.Name = name;
            SignUpData.username = username;
            SignUpData.password = password;
            SignUpData.productHistory = new List<ProductHistory>() { };

            var SignUpDataJson = JsonConvert.SerializeObject(SignUpData);

            var postUrl = "http://localhost:7100/api/Account/";
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
            var postUrl = "http://localhost:7100/api/Account/";
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Get(request);

            List<Account> accountList = JsonConvert.DeserializeObject<List<Account>>(response.Content);

            return accountList;
        }

    }
}
