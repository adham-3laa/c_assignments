using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_1.Context
{
   
    #region 

    [Table("Stud_Course")]
    public class Stud_Course
    {
        [ForeignKey(nameof(Student))]
        public int Stud_ID { get; set; }
        public Student Student { get; set; }

        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public decimal Grade { get; set; }
    }
    #endregion

}
