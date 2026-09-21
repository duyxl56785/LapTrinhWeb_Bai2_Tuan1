using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using System.Diagnostics;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET MVC");
        }

        public IActionResult About()
        {
            return Content("Họ và tên: Nguyễn Văn Duy"); 
        }

        public IActionResult Contact()
        {
            return Content("Email: nguyenvanduy@example.com"); 
        }
    }
}