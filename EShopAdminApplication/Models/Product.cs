using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAdminApplication.Models
{
    public class Product
    {
        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public string ProductDescription { get; set; }

        public double ProductPrice { get; set; }

        public double ProductRating { get; set; }
    }
}
