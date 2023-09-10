using Aggregate_Planing.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Conexion
{
    public class MyDBContexrt : DbContext
    {
        public MyDBContexrt()
        {

        }

        public MyDBContexrt(DbContextOptions<MyDBContexrt> options) : base(options)
        {

        }
        public virtual DbSet<AgreggationPlan> AgreggationPlans { get; set; }
        public virtual DbSet<Month> Months { get; set; }



        public virtual DbSet<AgreggationDetail> AgreggationDetails { get; set; }

        public virtual DbSet<AgregationDetailCost> AgreggationDetailsCosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                  optionsBuilder.UseSqlServer("Server=.;Database=Planing;user=sa;Password=1234;TrustServerCertificate=True;");
               // optionsBuilder.UseSqlServer("Server=WF1645\\SQLWISTON;Database=Planing;user=sa;Password=Diciembre2023$$;TrustServerCertificate=True;");
                
            }
        }
        
    }

   

   
}
