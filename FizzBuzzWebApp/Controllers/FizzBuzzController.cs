using FizzBuzzWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Utilities;

namespace FizzBuzzWebApp.Controllers
{
    public class FizzBuzzController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Process_Data([FromBody] FizzBuzz _data)
        {
            var values = _data.Value.Split(',').ToList();
           var result = Utility.Process(values);
            return Json(result);
        }
    }
}
