using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        // 1. Nhận id qua route URL: /Product/Detail/5 hoặc Query string
        // Dùng int? (nullable) để kiểm tra nếu người dùng không truyền id
        public IActionResult Detail(int? id)
        {
            if (!id.HasValue)
            {
                return Content("Lỗi: Vui lòng cung cấp mã sản phẩm (ID)!");
            }
            return Content($"Product ID = {id.Value}");
        }

        // 2. Nhận name qua Query string: /Product/Category?name=Laptop
        public IActionResult Category(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Content("Lỗi: Vui lòng cung cấp tên danh mục (Category name)!");
            }
            return Content($"Category = {name}");
        }
    }
}