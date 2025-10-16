using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Models.Shared
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } 
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; } 
        public bool isDeleted { get; set; }
    }
}
