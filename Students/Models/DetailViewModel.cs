using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class DetailViewModel
    {
        [Required]
        [Range(1,int.MaxValue ,ErrorMessage = "Please enter a value greater than 0")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Classroom { get; set; }
        [Required]
        public string Teacher { get; set; }
        [Range(0,100 , ErrorMessage = "Grade Point Average must be between 0-100.")]
        public int GradeAvarage { get; set; }
        public bool HomeworkCompleted { get; set; }
    }
}
