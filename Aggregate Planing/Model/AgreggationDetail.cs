using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Model
{
    public class AgreggationDetail
    {
        [Key]
        public int id { get; set; }

        [Required]
        [ForeignKey("AgreggationPlans")]
        public int idPlan { get; set; }

        [Required]
        [ForeignKey("Months")]
        public int idMonth { get; set; }

        [Required]
        public int businessDays { get; set; }

        [Required]

        public int Demand { get; set; }

        [Required]
        public int UnitPerOperador { get; set; }

        [Required]
        public int RequiredOperators { get; set; }

        [Required]
        public int actualOperators { get; set; }

        [Required]
        public int opertorsHired { get; set; }

        [Required]
        public int operatorsOff { get; set; }

        [Required]
        public int operatorsUsed { get; set; }

        [Required]
        public int unitsProduced { get; set; }

        [Required]
        public int unitsAvailable { get; set; }

        [Required]
        public int inventory { get; set; }

        [Required]

        public int missingUnits { get; set; }
    }   
}
