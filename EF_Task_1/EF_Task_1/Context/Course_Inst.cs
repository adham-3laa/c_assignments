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
    [Table("Course_Inst")]
    public class Course_Inst
    {
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        [InverseProperty(nameof(Course.Course_Insts))]
        public Course Course { get; set; }
        [ForeignKey(nameof(Instructor))]
        public int Inst_ID { get; set; }
        [InverseProperty(nameof(Instructor.Course_Insts))]
        public Instructor Instructor { get; set; }
        [Column("Evaluate")]
        public decimal evaluate { get; set; }
    }
    #endregion


}
