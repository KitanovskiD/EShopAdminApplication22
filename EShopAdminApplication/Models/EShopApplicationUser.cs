using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAdminApplication.Models
{
    public class EShopApplicationUser
    {
        public string Email { get; set; }

        public string NormalizedUserName { get; set; }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
