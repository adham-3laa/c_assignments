using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_1.Context

{
    #region fluent API 
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int inst_ID { get; set; }
        public DateTime HiringDate { get; set; }
    }
    #endregion
    #region convention 
    //public class Department
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int inst_ID { get; set; }
    //    public DateTime HiringDate { get; set; }
    //}
    #endregion
    #region Annotation
    //[Table("Departments")]
    //public class Department
    //{
    //    [Column("Dept_ID")]
    //    [Key]
    //    public int ID { get; set; }
    //    [Column("Dept_Name")]
    //    public string Name { get; set; }
    //    [Column("Inst_ID")]
    //    public int inst_ID { get; set; }
    //    [Column("Hiring_Date")]
    //    public DateTime HiringDate { get; set; }
    //}
    #endregion

}
