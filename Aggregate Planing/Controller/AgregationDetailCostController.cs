using Aggregate_Planing.Conexion;
using Aggregate_Planing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Controller
{
    public class AgregationDetailCostController
    {
        public MyDBContexrt dbContext = new MyDBContexrt();

        public AgregationDetailCostController()
        {

        }

        public void Create(int idPlan, int idMonth,double costToHires, double costToLayingOff, double costToLabour, double costToStore, double costForShortage)
        {
            
            AgregationDetailCost agregationDetailCost = new AgregationDetailCost();

            agregationDetailCost.idPlan = idPlan;
            agregationDetailCost.idMonth = idMonth;
            agregationDetailCost.costToHires = costToHires;
            agregationDetailCost.costTolayingOff = costToLayingOff; 
            agregationDetailCost.costToLabour = costToLabour;
            agregationDetailCost.costToStore = costToStore; 
            agregationDetailCost.costForShortages  = costForShortage;

            dbContext.AgreggationDetailsCosts.Add(agregationDetailCost);
            dbContext.SaveChanges();

        }

        public void Edit(int idPlan, int idMonth,double costToHires, double costToLayingOff,double costToLabour, double costToStore, double costForShortage)
        {
            AgregationDetailCost agregationDetailCost = dbContext.AgreggationDetailsCosts.FirstOrDefault(d => d.idPlan == idPlan && d.idMonth == idMonth);

            if(agregationDetailCost != null)
            {
                agregationDetailCost.idMonth=idMonth;
                agregationDetailCost.costToHires = costToHires;
                agregationDetailCost.costTolayingOff = costToLayingOff;
                agregationDetailCost.costToLabour = costToLabour;
                agregationDetailCost.costToStore = costToStore;
                agregationDetailCost.costForShortages= costForShortage;

                dbContext.SaveChanges(); 
            }

        }
        

        public List<double> GetPropertyValues(int idPlan, string propertyName)
        {
            var result = dbContext.AgreggationDetailsCosts.Where(detalle => detalle.idPlan == idPlan).OrderBy(detalle => detalle.idMonth)
            .Select(detalle => detalle.GetType().GetProperty(propertyName).GetValue(detalle, null)).ToList();

            var resultAsDouble = result.Select(value => Convert.ToDouble(value)).ToList();

            return resultAsDouble;
        }

    }
}
