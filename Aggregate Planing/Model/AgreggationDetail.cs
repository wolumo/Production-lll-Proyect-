using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Model
{
    public class AgreggationDetail
    {
        [Key]
        public int id { get; set; }

        [Required]
        [ForeignKey("AgreggationPlan")]
        public int idPlan { get; set; }

        [Required]
        [ForeignKey("Month")]
        public int idMonth { get; set; }
    }
}
