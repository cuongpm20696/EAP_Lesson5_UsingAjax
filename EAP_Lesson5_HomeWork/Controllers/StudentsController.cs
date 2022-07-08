using EAP_Lesson5_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAP_Lesson5_HomeWork.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        StudentContext context = new StudentContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult createStudent (Student std)
        {
            context.Students.Add(std);
            context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
        public JsonResult getStudent(string id)
        {
            List<Student> students = new List<Student>();
            students = context.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}