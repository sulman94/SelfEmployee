using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SelfEmployee.DBHandler.DBContext;
using SelfEmployee.Models.ConfigurationRepositories;
using SelfEmployee.Models.ViewModels;

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
        public async Task<IActionResult> TaskList()
        {
            
            TaskListView taskListView = new TaskListView();
            taskListView.TaskLists = new List<Tasks>();
            var TaskList = await _ctx.Tasks.ToListAsync();
            taskListView.TaskLists.AddRange(TaskList);
            ViewBag.Categories = await _ctx.TaskCategories.Where(x => x.IsActive == true).Select(x => new TaskCategory { Id = x.Id, CategoryName = x.CategoryName }).ToListAsync();
            return View(taskListView);
        }
    }
}
