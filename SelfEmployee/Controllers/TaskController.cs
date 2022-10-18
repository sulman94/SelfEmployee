using Microsoft.AspNetCore.Mvc;

namespace SelfEmployee.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult PostTask()
        {
            return View();
        }
    }
}
