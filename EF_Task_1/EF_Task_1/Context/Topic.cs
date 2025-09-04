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
    //internal class Topic
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }

    //}
    #endregion
    #region Annotation
    [Table("Topics")]
    internal class Topic
    {
        [Key]
        public int ID { get; set; }
        [Column("Name")]
        public string Name { get; set; }
    }
    #endregion
}
