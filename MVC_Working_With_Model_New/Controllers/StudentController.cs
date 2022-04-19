using Microsoft.AspNetCore.Mvc;
using MVC_Working_With_Model_New.Models;

namespace MVC_Working_With_Model_New.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student stud)
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Student stud)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteConform(int id )
        {
            return View();
        }

    }
}
