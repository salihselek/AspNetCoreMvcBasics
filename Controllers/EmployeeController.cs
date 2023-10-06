using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello world. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var names = new String[]{
                "Salih",
                "Veli",
                "Furkan"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){
                    Id=1,
                    FirstName="Salih",
                    LastName="SELEK",
                    Age=20
                },
                new Employee(){
                    Id=2,
                    FirstName="Veli",
                    LastName="SELEK",
                    Age=30
                },
                new Employee(){
                    Id=3,
                    FirstName="Furkan",
                    LastName="SELEK",
                    Age=10
                },
            };
            return View("Index3", list);
        }
    }
}