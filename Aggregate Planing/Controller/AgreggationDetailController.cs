using Aggregate_Planing.Conexion;
using Aggregate_Planing.Migrations;
using Aggregate_Planing.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Planing.Controller
{
    public class AgreggationDetailController
    {
        public MyDBContexrt dBContext = new MyDBContexrt();
        public void Create(int idPlan, int idMonth,int WorkingDays, int Demand, int UnitPerOperador, int RequiredOperators,int actualOperators, int operatorsHired, int operatorsOff, int operatorsUsed, 
            int unitsProduced, int unitsAvailable, int inventory, int missingUnits)
        {
            AgreggationDetail agreggationDetail = new AgreggationDetail();

            agreggationDetail.idPlan = idPlan;
            agreggationDetail.idMonth = idMonth;
            agreggationDetail.WorkingDays = WorkingDays;
            agreggationDetail.Demand = Demand;
            agreggationDetail.UnitPerOperador = UnitPerOperador;
            agreggationDetail.RequiredOperators = RequiredOperators;
            agreggationDetail.actualOperators = actualOperators;
            agreggationDetail.opertorsHired = operatorsHired;
            agreggationDetail.operatorsOff = operatorsOff;
            agreggationDetail.operatorsUsed = operatorsUsed;
            agreggationDetail.unitsProduced = unitsProduced;
            agreggationDetail.unitsAvailable = unitsAvailable;
            agreggationDetail.inventory = inventory; 
            agreggationDetail.missingUnits = missingUnits;

            dBContext.AgreggationDetails.Add(agreggationDetail);
            dBContext.SaveChanges();

        }

        public void Edit(int idPlan, int idMonth, int WorkingDays, int Demand , int UnitPerOperador,int RequiredOperators, int actualOperators, int operatorsHired, int operatorsOff, int operatorsUsed,
            int unitsProduced, int unitsAvailable, int inventory, int missingUnits)
        {
            AgreggationDetail agreggationDetail = dBContext.AgreggationDetails.FirstOrDefault(d => d.idPlan == idPlan && d.idMonth == idMonth);

            if(agreggationDetail != null)
            {
                agreggationDetail.WorkingDays = WorkingDays;
                agreggationDetail.Demand = Demand;
                agreggationDetail.UnitPerOperador = UnitPerOperador;    
                agreggationDetail.RequiredOperators = RequiredOperators;
                agreggationDetail.actualOperators = actualOperators;
                agreggationDetail.opertorsHired = operatorsHired;
                agreggationDetail.unitsProduced = unitsProduced;
                agreggationDetail.unitsAvailable = unitsAvailable;
                agreggationDetail.inventory = inventory;
                agreggationDetail.missingUnits = missingUnits;

                dBContext.SaveChanges();

            }
        }

        public int getLastMonth(int idPlan)
        {
            var lastMonth = dBContext.AgreggationDetails.Where(ad => ad.idPlan == idPlan).OrderByDescending(ad => ad.idMonth).Select(ad => ad.idMonth).FirstOrDefault();
            return lastMonth;
        }

        public int getInitialMonth(int idPlan)
        {
            var initialMonth = dBContext.AgreggationDetails.Where(ad => ad.idPlan == idPlan).Select(ad => ad.idMonth).FirstOrDefault();
            return initialMonth;
        }



        public List<int> GetPropertyValues(int idPlan, string propertyName)
        {

            var resultado = dBContext.AgreggationDetails
            .Where(detalle => detalle.idPlan == idPlan)
            .OrderBy(detalle => detalle.idMonth)
            .Select(detalle => detalle.GetType().GetProperty(propertyName).GetValue(detalle, null)).ToList();


            var resultadoComoInt = resultado.Select(valor => Convert.ToInt32(valor)).ToList();




            return resultadoComoInt;
        }

        public void Delete(int idPlan)
        {
            var DataToDelete = dBContext.AgreggationDetails.Where(d => d.idPlan == idPlan).ToList();

            if (DataToDelete.Any())
            {
                dBContext.RemoveRange(DataToDelete);
                dBContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("No se encontraron registros en el detalle para eliminar");
            }
        }


    }
}
