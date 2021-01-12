using Students.Context;
using Students.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Service
{
    public class StudentService
    {
        #region StudentContext injection
        private readonly StudentContext _studentContext;
        public StudentService(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        #endregion

        #region Method that get all the Students
        public List<StudentEntity> GetAllStudents()
        {
            return _studentContext.Students;
        }
        #endregion

        #region Method of adding new Students
        public void AddStudent(StudentEntity entity)
        {
            _studentContext.Students.Add(entity);
        } 
        #endregion

    }
}
