using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using System.Diagnostics;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index hoặc /
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET MVC");
        }

        // GET: /Home/About
        public IActionResult About()
        {
            return Content("Họ và tên: Nguyễn Văn Duy"); // Thay bằng tên của bạn
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            return Content("Email: nguyenvanduy@example.com"); // Thay bằng email của bạn
        }
    }
}