using Microsoft.AspNetCore.Mvc;
using Students.Models;
using Students.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Controllers
{
    public class StudentController : Controller
    {
        #region StudentService Inject edildi
        private readonly StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        public IActionResult Index()
        {
            var studentEntities = _studentService.GetAllStudents();
            var studentViewModelList = new List<StudentViewModel>();
            foreach (var entity in studentEntities)
            {
                studentViewModelList.Add(new StudentViewModel
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Surname = entity.Surname,
                    Classroom = entity.Classroom,
                    Teacher = entity.Teacher
                });
            }
            return View(studentViewModelList);
        }
    }
}
