using EShopAdminApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EShopAdminApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();

            string URL = "https://localhost:44386/api/Admin/GetOrders";

            HttpResponseMessage response = client.GetAsync(URL).Result;

            var result = response.Content.ReadAsAsync<List<Order>>().Result;

            return View(result);
        }
    }
}
