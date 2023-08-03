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

        [Required]
        public int operatorAverage { get; set; }

        [Required]
        public int initialCurrentOperators { get; set; }

        [Required]

        public double dailyCosPerOver { get; set; }

        [Required]
        public double costOfHiring { get; set; }

        [Required]
        public double costOfDismissing { get; set; }

        [Required]
        public double costToStore { get; set; }

        [Required]
        public double shortageCost { get; set; }

        [Required]

        public int initialInventory { get; set; }

        [Required]
        public double hoursPerWeek { get; set; }

    }
}
