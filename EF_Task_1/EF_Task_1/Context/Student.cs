using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_1.Context
{
    
    #region Annotation
    [Table("Students")]
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Column("FName")]
        public string FName { get; set; }
        [Column("LName")]
        public string LName { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("Age")]
        public int Age { get; set; }

        #region relations

        [Column("DepID")]
        [ForeignKey(nameof(Department))]
        public int DepID { get; set; }
        public Department Department { get; set; }
        [InverseProperty(nameof(Stud_Course.Student))]
        public List<Stud_Course> Stud_Courses { get; set; }

        #endregion
    }
    #endregion
}
