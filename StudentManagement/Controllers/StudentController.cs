using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: /Student/Info
        public IActionResult Info()
        {
            // 1. Name dùng ViewBag
            ViewBag.Name = "Nguyễn Văn A";

            // 2. Age dùng ViewData
            ViewData["Age"] = 20;

            // 3. Major dùng Model
            var model = new StudentInfo
            {
                Major = "CNTT"
            };

            return View(model); // Truyền model vào View
        }
    }
}