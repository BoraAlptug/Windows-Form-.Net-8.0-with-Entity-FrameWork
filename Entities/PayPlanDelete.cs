using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.Entities
{
    public class PayPlanDelete
    {
        [Key]
        public int? bimno { get; set; }
        public string? aktifpasif { get; set; }
    }
}
