using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_PBO_1.Model
{
    internal class SendAccount
    {
        public string Name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<ProductHistory> productHistory { get; set; }
    }
}
