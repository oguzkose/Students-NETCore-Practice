using Microsoft.AspNetCore.Mvc;
using Students.Entity;
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
        #region StudentService Inject
        private readonly StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        #region Index action method
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
        #endregion

        #region Create action methods
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            StudentEntity newStudent = new StudentEntity
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname,
                Classroom = model.Classroom,
                Teacher = model.Teacher
            };
            _studentService.AddStudent(newStudent);


            return View();
        }
        #endregion

        #region Edit action methods
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var entity = _studentService.GetStudents(id);
            var model = new StudentViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname = entity.Surname,
                Classroom = entity.Classroom,
                Teacher = entity.Teacher
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(StudentViewModel model)
        {
            StudentEntity newEntity = new StudentEntity
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname,
                Classroom = model.Classroom,
                Teacher = model.Teacher
            };
            _studentService.Edit(newEntity);
            return RedirectToAction(nameof(Index), "Student");
        }
        #endregion

        #region Detail action method will come here
        //!!!!!!!
        #endregion

        #region Delete action method
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction(nameof(Index), "Student");
        } 
        #endregion
    }
}
