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
    //public class Student
    //{
    //    public int ID { get; set; }
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public string Address { get; set; }
    //    public int Age { get; set; }
    //    public int DepID { get; set; }

    //}
    #endregion
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
        [Column("DepID")]
        public int DepID { get; set; }

    }
    #endregion
}
