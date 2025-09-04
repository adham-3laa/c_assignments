using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_1.Context
{
    #region convention
    //public class Stud_Course
    //{
    //    public int ID { get; set; } // Primary Key because it out error if not exist
    //    public int Stud_ID { get; set; }
    //    public int Course_ID { get; set; }
    //    public decimal Grade { get; set; }
    //}
    #endregion
    #region Annotation

    [Table("Stud_Course")]
    public class Stud_Course
    {
        [Key]
        public int Stud_ID { get; set; }
        [Required]
        [Column("Course_ID")]
        public int Course_ID { get; set; }
        [Column("Grade")]
        public decimal Grade { get; set; }
    }
    #endregion

}
