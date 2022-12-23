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
        public string productUrl = "http://localhost:7100/api/Product/";
        public void PostProduct(string name, bool isAvailable)
        {
            SendProduct CheckOutItems = new SendProduct();

            CheckOutItems.name = name;
            CheckOutItems.isAvailable = isAvailable;

            var CheckOutItemsJson = JsonConvert.SerializeObject(CheckOutItems);

            var postUrl = productUrl;
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
            var postUrl = productUrl;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Get(request);
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(response.Content);
            return productList;
        }
        public Product GetProductById(int id)
        {
            var postUrl = productUrl + id;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Get(request);

            Product foundProduct = JsonConvert.DeserializeObject<Product>(response.Content);

            return foundProduct;
        }

        public void EditProductById(Product editProduct, int id)
        {
            var EditedProductJson = JsonConvert.SerializeObject(editProduct);

            var postUrl = productUrl + id;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/xml");
            request.AddJsonBody(editProduct);

            var response = client.Put(request);
        }

        public void DeleteProductById(int id)
        {
            var postUrl = productUrl + id;
            var client = new RestClient();
            var request = new RestRequest()
            {
                Resource = postUrl
            };
            var response = client.Delete(request);
        }
    }
}

