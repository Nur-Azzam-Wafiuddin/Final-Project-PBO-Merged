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
    internal class ProductController
    {
        public void PostProduct(string name, bool isAvailable)
        {
            SendProduct CheckOutItems = new SendProduct();

            CheckOutItems.name= name;
            CheckOutItems.isAvailable = isAvailable;

            var CheckOutItemsJson = JsonConvert.SerializeObject(CheckOutItems);

            var postUrl = "http://localhost:7100/api/Product/";
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/xml");
            request.AddJsonBody(CheckOutItemsJson);

            var response = client.Post(request);
        }

        public List<Product> GetAllProduct()
        {
            var postUrl = "http://localhost:7100/api/Product/";
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Get(request);
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(response.Content);
            return productList;
        }
    }
}

