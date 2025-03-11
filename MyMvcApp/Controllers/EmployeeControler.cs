using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MyMvcApp.Controllers
{
    public class EmployeeController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "Thanh Tam";
        }
    }
}

