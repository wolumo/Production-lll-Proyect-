using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Model
{
    public class AgregationDetailCost
    {
        [Key]
        public int AgregationDetailCostId { get; set; }

        [Required]
        [ForeignKey("idPlan")]
        public int idPlan { get; set; }

        [Required]
        [ForeignKey("Months")]
        public int idMonth { get; set; }

        [Required]
        public double costToHires { get; set; }

        [Required]
        public double costTolayingOff { get; set; }

        [Required]
        public double costToLabour { get; set; }

        [Required]
        public double costToStore { get; set; }

        [Required]
        public double costForShortages { get; set; }

    }
}
