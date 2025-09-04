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
        [Column("Top_ID")]
        public int Top_ID { get; set; }
    }
    #endregion

}
