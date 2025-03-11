using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using System.Text.Encodings.Web;
namespace MyMvcApp.Controllers
{
    public class EmployeeController : Controller
    { 
        // GET: /Employee/
        public IActionResult Index()
        {
            return View();
        } 
        public string some(){
            return "le thanh tam";
        }
        [HttpPost]
       public IActionResult Index(Employee employee){
         ViewBag.id = employee.Id;
         ViewBag.name = employee.FullName;
         ViewBag.gender = employee.Gender;
         ViewBag.email = employee.email;
         ViewBag.age = employee.Age;
         return View();
        }
    }
}

