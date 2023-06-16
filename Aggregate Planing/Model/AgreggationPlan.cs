using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Model
{
    public class AgreggationPlan
    {
        [Key]
        public int idPlan { get; set; }
        public string NamePlan { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
