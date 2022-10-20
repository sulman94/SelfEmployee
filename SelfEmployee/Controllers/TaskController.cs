using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SelfEmployee.DBHandler.DBContext;

namespace SelfEmployee.Controllers
{
    public class TaskController : Controller
    {
        private readonly SelfEmployeeContext _ctx;
        public TaskController(SelfEmployeeContext context)
        {
            _ctx = context;
        }
        public async Task<IActionResult> PostTask()
        {
            ViewBag.Categories = new SelectList(await _ctx.TaskCategories.Where(x => x.IsActive == true).Select(x => new { x.Id, x.CategoryName }).ToListAsync(), "Id", "CategoryName");
            return View();
        }
    }
}
