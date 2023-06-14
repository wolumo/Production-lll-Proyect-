using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Model
{
    public class Month
    {
        [Key]
        public int idMonth { get; set; }
        public string MonthName { get; set; }

    }
}
