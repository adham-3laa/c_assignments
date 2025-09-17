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

        #region relations
        [Column("Dept_ID")]
        public int Dept_ID { get; set; }
        public Department Department { get; set; }


        [InverseProperty(nameof(Course_Inst.Instructor))]
        public List<Course_Inst> Course_Insts { get; set; }

        #endregion

    }
    #endregion
}
