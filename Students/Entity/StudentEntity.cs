﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Entity
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Classroom { get; set; }
        public string Teacher { get; set; }
        public int GradeAvarage { get; set; }
        public bool HomeworkCompleted { get; set; }

    }
}
