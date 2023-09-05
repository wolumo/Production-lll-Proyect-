using Aggregate_Planing.Conexion;
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
    }
}
