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

        #region Method that get Students by id
        public StudentEntity GetStudents(int id)
        {
            return _studentContext.Students.FirstOrDefault(x => x.Id == id);
        }
        #endregion

        #region Method of editing Students
        internal void Edit(StudentEntity newEntity)
        {
            var entity = _studentContext.Students.FirstOrDefault(x => x.Id == newEntity.Id);
            _studentContext.Students.Remove(entity);
            _studentContext.Students.Add(newEntity);
        } 
        #endregion

        #region Method of deleting Students
        internal void Delete(int id)
        {
            var deletedEntity = _studentContext.Students.FirstOrDefault(x => x.Id == id);
            _studentContext.Students.Remove(deletedEntity);
        }
        #endregion
        public StudentEntity Detail(int id)
        {
            return _studentContext.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}
