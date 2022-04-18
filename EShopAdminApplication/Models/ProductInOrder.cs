using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAdminApplication.Models
{
    public class ProductInOrder
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid OrderId { get; set; }
        //public Order Order { get; set; }
        public int Quantity { get; set; }

    }
}
