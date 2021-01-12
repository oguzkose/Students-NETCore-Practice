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
        #region StudentContext inject edildi
        private readonly StudentContext _studentContext;
        public StudentService(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        #endregion

        #region Tüm Student'ları getiren metot GetAllStudents()
        public List<StudentEntity> GetAllStudents()
        {
            return _studentContext.Students;
        } 
        #endregion



    }
}
