using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NkmLesson10Lap1.Models;

namespace NkmLesson10Lap1.Controllers
{
    [Route("Admin/Student")]
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            listStudents = new List<Student>() {
                new Student(){Id =1, Name ="Manhdz", Branch = Branch.IT, Gender = Gender.Male, IsRegular = true, Address = "505A4",Email ="Manhdz@gmail.com" },
                new Student(){Id =2, Name ="Hieuxz",Branch=Branch.CE, Gender=Gender.Male, IsRegular = true, Address = "505A4",Email ="Hieuxz@gmail.com" },
                new Student(){Id =3, Name ="Huongyh",Branch=Branch.BE,Gender = Gender.Female,IsRegular = true, Address = "505A4",Email ="Huongyh@gmail.com" },
                new Student(){Id =4, Name ="Jack",Branch=Branch.EE, Gender = Gender.Male, IsRegular = false,Address = "401A4",Email="Jack@gmail.com" },
            };
        }
        [Route("List", Name = "student_list")]
        public IActionResult Index()
        {
            return View(listStudents);
        }
        [HttpGet]
        [Route("Add", Name = "student_add")]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
    {
        new SelectListItem { Text = "IT", Value = "1" },
        new SelectListItem { Text = "BE", Value = "2" },
        new SelectListItem { Text = "CE", Value = "3" },
        new SelectListItem { Text = "EE", Value = "4" }
    };

            return View();
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Count > 0 ? listStudents.Last<Student>().Id + 1 : 1;
            listStudents.Add(s);
            return View("Index", listStudents);
        }
    }
}
