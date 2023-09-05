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

      
    }
}
