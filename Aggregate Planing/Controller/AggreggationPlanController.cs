using Aggregate_Planing.Conexion;
using Aggregate_Planing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Controller
{
    public class AggreggationPlanController
    {
       public MyDBContexrt dbContext = new MyDBContexrt();
        public int Create(string planName,double operatorAverage, double initialCurrentOperatos, double dailyCosPerOver, double costOfHiring, double costOfDismissing, double costToStore, double shortageCost,double initialInventory,
            double hoursPerWeek)
        {
            AgreggationPlan agreggationPlan = new AgreggationPlan();

            agreggationPlan.NamePlan = planName;
            agreggationPlan.CreatedDateTime = DateTime.Now;
            agreggationPlan.operatorAverage = operatorAverage;
            agreggationPlan.initialCurrentOperators = initialCurrentOperatos;
            agreggationPlan.dailyCosPerOver = dailyCosPerOver;
            agreggationPlan.costOfHiring = costOfHiring;
            agreggationPlan.costOfDismissing = costOfDismissing;
            agreggationPlan.costToStore = costToStore;
            agreggationPlan.shortageCost = shortageCost;
            agreggationPlan.initialInventory = initialInventory;
            agreggationPlan.hoursPerWeek = hoursPerWeek;

            dbContext.AgreggationPlans.Add(agreggationPlan);   
            dbContext.SaveChanges();

            return agreggationPlan.idPlan;
        }

        public void Edit (int idPlan, string planName, double operatorAverage, double initialCurrentOperatos, double dailyCosPerOver, double costOfHiring, double costOfDismissing, double costToStore, double shortageCost,double initialInventory, 
            double hoursPerWeek)
        {
            AgreggationPlan agreggationPlan = dbContext.AgreggationPlans.FirstOrDefault( d =>d.idPlan == idPlan);

            if(agreggationPlan != null)
            {
                agreggationPlan.NamePlan = planName;
                agreggationPlan.CreatedDateTime = DateTime.Now; 
                agreggationPlan.operatorAverage = operatorAverage;
                agreggationPlan.initialCurrentOperators = initialCurrentOperatos; 
                agreggationPlan.dailyCosPerOver = dailyCosPerOver;
                agreggationPlan.costOfHiring = costOfHiring;    
                agreggationPlan.costOfDismissing = costOfDismissing;
                agreggationPlan.costToStore = costToStore;
                agreggationPlan.shortageCost = shortageCost;
                agreggationPlan.initialInventory = initialInventory;
                agreggationPlan.hoursPerWeek = hoursPerWeek;

                dbContext.SaveChanges();

            }
        }
      public List<AgreggationPlan> showPlans()
        {
            return dbContext.AgreggationPlans.ToList();
        }

        public List<double> GetPropertyValues(int idPlan, string properyName)
        {
            var result = dbContext.AgreggationPlans.Where(detalle => detalle.idPlan == idPlan)
                .Select(detalle => detalle.GetType()
                .GetProperty(properyName)
                .GetValue(detalle, null)).ToList();

            var resultAsDouble = result.Select(value => Convert.ToDouble(value)).ToList();

            return resultAsDouble;  
        }


    }
}
