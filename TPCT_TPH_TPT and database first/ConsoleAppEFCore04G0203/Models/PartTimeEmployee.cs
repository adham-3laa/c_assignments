using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCT_TPH_TPT.Models
{
    public class PartTimeEmployee:Employee
    {
        public decimal HourRate { get; set; }

        public int CountOfHours { get; set; }
    }
}
