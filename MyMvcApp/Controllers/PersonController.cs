using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MyMvcApp.Models;
namespace MyMvcApp.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        } 
        public string Halo()
        {
            return "LeThanhTam";
        }

        [HttpPost]
        public IActionResult Index(Person ps){
            string add ="Thành Viên" + ps.id + " " + ps.FullName +" " + ps.Gender +" "+ ps.email;
            ViewBag.inforPerson = add;
            return View();
        }
    }
}
