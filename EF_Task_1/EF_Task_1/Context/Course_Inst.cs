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
    //public class Course_Inst
    //{
    //    public int ID { get; set; } // Primary Key because it out error if not exist
    //    public int Course_ID { get; set; }
    //    public int Inst_ID { get; set; }
    //    public decimal evaluate { get; set; }
    //}
    #endregion
    #region Annotation
    [Table("Course_Inst")]
    public class Course_Inst
    {
        [Key]
        public int Course_ID { get; set; }
        [Required]
        public int Inst_ID { get; set; }
        [Column("Evaluate")]
        public decimal evaluate { get; set; }
    }
    #endregion


}
