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
    //public class Course
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Duration { get; set; }
    //    public string Description { get; set; }
    //    public int Top_ID { get; set; }
    //}
    #endregion
    #region Annotation
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Duration")]
        public int Duration { get; set; }
        [Column("Description")]
        public string Description { get; set; }

        #region relations
        [Column("Top_ID")]
        [ForeignKey(nameof(Topic))]
        public int Top_ID { get; set; }
        [InverseProperty(nameof(Topic.Courses))]
        public Topic Topic { get; set; }
        [InverseProperty(nameof(Course_Inst.Course))]
        public List<Course_Inst> Course_Insts { get; set; }
        [InverseProperty(nameof(Stud_Course.Course))]
        public List<Stud_Course>  Stud_Courses { get; set; }
        #endregion
    }
    #endregion

}
