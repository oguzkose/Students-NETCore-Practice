using Students.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Context
{
    public class StudentContext
    {
        public List<StudentEntity> Students { get; set; }
        public StudentContext()
        {
            Students = new List<StudentEntity>
            {
                new StudentEntity
                {
                    Id=1,
                    Name="Oğuz",
                    Surname="Köse",
                    Classroom="1-A",
                    Teacher="Ramazan Kartal",
                    GradeAvarage=80,
                    HomeworkCompleted=true
                },
                new StudentEntity
                {
                    Id=2,
                    Name="Ahmet",
                    Surname="Yılmaz",
                    Classroom="1-B",
                    Teacher="Mehmet Öğretmen",
                    GradeAvarage=75,
                    HomeworkCompleted=false
                }
            };
        }
    }
}
