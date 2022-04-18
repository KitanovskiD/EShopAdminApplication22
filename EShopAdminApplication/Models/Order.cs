using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public EShopApplicationUser User { get; set; }

        public IEnumerable<ProductInOrder> ProductInOrders { get; set; }
    }
}
