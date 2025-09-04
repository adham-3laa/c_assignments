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
    //public class Instructor
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Address { get; set; }
    //    public double Salary { get; set; }
    //    public double Bouns { get; set; }
    //    public int HourRate { get; set; }
    //    public int Dept_ID { get; set; }

    //}
    #endregion

    #region Annotation
    [Table("Instructors")]
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Column("Name")]
        [Required]
        public string Name { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("Salary")]
        public double Salary { get; set; }
        [Column("Bouns")]
        public double Bouns { get; set; }
        [Column("HourRate")]
        public int HourRate { get; set; }
        [Column("Dept_ID")]
        public int Dept_ID { get; set; }

    }
    #endregion
}
