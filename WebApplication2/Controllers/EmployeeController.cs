using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public ApplicationDbContext context=new ApplicationDbContext();
        public IActionResult Index()
        {
            var employee= context.Employees1.ToList();
            return View("Index",employee);
        }
    }
}
