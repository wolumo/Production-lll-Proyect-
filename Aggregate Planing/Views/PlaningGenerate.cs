using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggregate_Planing.Views
{
    public partial class PlaningGenerate : Form
    {

        private int initialMonth;
        private int finalMonth;
        private double operatorAverage;
        private double initialCurrentOperators;
        private double dailyCosPerOver;
        private double costOfHiring;
        private double costOfDismissing;
        private double costToStore;
        private double shortageCost;
        private double initialInventory;
        private double hoursPerWeek;

        string[] months = new string[]{
        "Enero", "Febrero", "Marzo", "Abril", "Mayo",
        "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
        "Noviembre", "Diciembre"};

        string[] requiredData = new string[]
        {
            "Produccion Promedio Por Operario", "Operarios Actuales Iniciales", "Costo Diario Por Hornal",
            "Costo Por Contratar Un Operario" , "Costo Por Despedir Un Operario", "Costo por Almacenar" , "Costo Por Faltante" , "Inventario Inicial",
            "Horas Por Hornal De Trabajo"
        };

        string[] Measures = new string[]
        {
            "Diario" , "Trabajadores" , "Diario" , "Empleado", "Empleado", "Unidad", "Unidad", "Unidad" , "Horas"
        };

        string[] InitialRows = new string[]
        {
            "Dias laborales", "Demanda" , "Unidades por operario" , "Operarios Requeridos", "Operarios Actuales",
            "Operarios Contratados", "Operarios Despedidos" , "Operarios Utilizados" , "Unidades Producidas" , "Unidades Disponibles",
            "Inventario", "Unidades Faltantes"
        };

        string[] costRows = new string[]
        {
            "Por Contratar" , "Por Despedir" , "Por Mano De Obra" , "Por De Almacenar" ,
            "Por Faltantes" , "Costo Total"
        };

        public PlaningGenerate()
        {
            InitializeComponent();
          
            
        }

        public PlaningGenerate(int initialMonth, int finalMonth)
        {
            this.initialMonth=initialMonth;
            this.finalMonth=finalMonth;
            InitializeComponent();
            
        }

        private void PlaningGenerate_Load(object sender, EventArgs e)
        {
            ChargeInitialDgv();
            ChargeRequiredDataDgv();
            ChargeCostDgv();
        }

        private void ChargeInitialDgv()
        {
            
            if (initialMonth <= finalMonth)
            {
                dgvInitialTable.ColumnCount = (finalMonth-initialMonth) +3; //esta bien 
                dgvInitialTable.Columns[0].Name = "Datos";
                for (int i = initialMonth; i <=finalMonth; i++)
                {
                    string month = months[i];
                    dgvInitialTable.Columns[i -initialMonth+1].Name = month;
                }
                dgvInitialTable.Columns[dgvInitialTable.ColumnCount-1].Name = "Total";
            }

       

            for (int i = 0; i <= InitialRows.Length-1; i++)
            {
                string rows = InitialRows[i];
                dgvInitialTable.Rows.Add(rows);

            }

        }

        private void ChargeRequiredDataDgv()
        {
            dgvRequiredData.ColumnCount = 3;
            dgvRequiredData.Columns[0].Name = "Datos";
            dgvRequiredData.Columns[1].Name = "Valor";
            dgvRequiredData.Columns[2].Name = "Medidas";

            for (int i = 0; i < requiredData.Length; i++)
            {
                string requiredRows = requiredData[i];
                dgvRequiredData.Rows.Add(requiredRows);
            }

            

            for (int i = 0; i < Measures.Length; i++)
            {
                string measureRows = Measures[i];
                dgvRequiredData.Rows[i].Cells[2].Value = measureRows;   
            }

        
        }

        private void ChargeCostDgv()
        {
            if (initialMonth <= finalMonth)
            {
                dgvPlanCost.ColumnCount = (finalMonth-initialMonth) +3; //esta bien 
                dgvPlanCost.Columns[0].Name = "Datos";
                for (int i = initialMonth; i <=finalMonth; i++)
                {
                    string month = months[i];
                    dgvPlanCost.Columns[i -initialMonth+1].Name = month;
                }
                dgvPlanCost.Columns[dgvPlanCost.ColumnCount-1].Name = "Total";
            }

            for (int i = 0; i < costRows.Length; i++)
            {
                string rows = costRows[i];
                dgvPlanCost.Rows.Add(rows);
            }

        }

        private void SumCalculate()
        {
            double totalSum = 0;
            double value = 0;
           

            for (int e = 0; e < dgvInitialTable.RowCount-1; e++)
            {
                if (e ==3)
                {
                    Console.WriteLine("Dont do anything");  
                }
                else
                {
                    for (int i = 0; i < dgvInitialTable.ColumnCount-1; i++)
                    {
                        if (i+1 == dgvInitialTable.ColumnCount-1)
                        {
                            dgvInitialTable.Rows[e].Cells[dgvInitialTable.ColumnCount-1].Value = totalSum;
                            totalSum = 0;
                        }
                        else
                        {
                            value = Convert.ToDouble(dgvInitialTable.Rows[e].Cells[i+1].Value);
                            totalSum += value;
                        }
                    }
                }
            }

          
        }
        
        private void getDgvRequiredDataValues()
        {
            double[] values = new double[9];

            for (int i = 0; i < 9; i++)
            {
                values[i] = Convert.ToDouble(dgvRequiredData.Rows[i].Cells[1].Value);
            }

            operatorAverage = values[0];
            initialCurrentOperators = values[1];
            dailyCosPerOver = values[2];
            costOfHiring = values[3];
            costOfDismissing = values[4];
            costToStore = values[5];
            shortageCost = values[6];
            initialInventory = values[7];
            hoursPerWeek = values[8];

        }

        private void UnitsPerOperator()
        {
            double unitsPerOperator = 0;
            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                if(i == dgvInitialTable.ColumnCount-1)
                {
                    return;
                }
                double businessDay = Convert.ToDouble(dgvInitialTable.Rows[0].Cells[i].Value);
                unitsPerOperator = businessDay * operatorAverage;
                dgvInitialTable.Rows[2].Cells[i].Value= unitsPerOperator;
                unitsPerOperator = 0; //Reset the value
            }
        }

        private void RequiredOperators()
        {

            double totalDemand = Convert.ToDouble(dgvInitialTable.Rows[1].Cells[dgvInitialTable.ColumnCount-1].Value);
            double totalUnitPerOperator = Convert.ToDouble(dgvInitialTable.Rows[2].Cells[dgvInitialTable.ColumnCount-1].Value);

            double RequiredOperators = Math.Round((totalDemand / totalUnitPerOperator));


            for (int i = 1; i < dgvInitialTable.ColumnCount; i++)
            {
                dgvInitialTable.Rows[3].Cells[i].Value = RequiredOperators;
            }
        }

        private void dgvInitialTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (updatingTotal) return;

            //if(e.ColumnIndex == e.ColumnIndex && e.RowIndex >=0)
            //{
            //    updatingTotal=true;

            //    double insertedNumber = Convert.ToDouble(dgvInitialTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //    total += insertedNumber;

            //    dgvInitialTable.Rows[e.RowIndex].Cells[dgvInitialTable.ColumnCount-1].Value = total;

            //    updatingTotal=false;

            //}
            }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            getDgvRequiredDataValues();
            UnitsPerOperator();
            SumCalculate(); //First Call Because we need the total Demand and Operators to RequiredOperators.
            RequiredOperators();
            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                if (i ==1)
                {
                    actualOperators(true); //True Because is the first value
                    operatorsHired();
                    operatorsOff();
                    operatorsUsed();
                }
                else
                {
                    actualOperators(false); //False Because the first value was setted.
                    operatorsHired();
                    operatorsOff();
                    operatorsUsed();
                }
            }
            unitsProduced();
            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                unitsAvailable();
                inventory();
            }
            SumCalculate();    

        }

        private void actualOperators(bool firstValue)
        {
            double value = 0;
            if (firstValue)
            {
                value = initialCurrentOperators;
                dgvInitialTable.Rows[4].Cells[1].Value = value;
            }
            else
            {
                for (int i = 2; i < dgvInitialTable.ColumnCount-1; i++)
                {
                    value = Convert.ToDouble(dgvInitialTable.Rows[7].Cells[i-1].Value);
                    dgvInitialTable.Rows[4].Cells[i].Value = value; //|Aca va a pegar
                }
                
            }
        }
        private void operatorsHired()
        {
            double operatorsHired = 0;
            double operatorsRequired = 0;
            double actualOperators = 0;

            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                operatorsRequired = Convert.ToDouble(dgvInitialTable.Rows[3].Cells[i].Value);
                actualOperators = Convert.ToDouble(dgvInitialTable.Rows[4].Cells[i].Value);

                if(operatorsRequired > actualOperators)
                {
                    operatorsHired = operatorsRequired - actualOperators;
                }
                else
                {
                    operatorsHired = 0;
                }

                dgvInitialTable.Rows[5].Cells[i].Value = operatorsHired;
            }
        }

        private void operatorsOff()
        {
            double operatorsOff = 0;
            double operatorRequired = 0;
            double actualOperators = 0;

            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                actualOperators = Convert.ToDouble(dgvInitialTable.Rows[4].Cells[i].Value);
                operatorRequired = Convert.ToDouble(dgvInitialTable.Rows[3].Cells[i].Value);

                if (actualOperators > operatorRequired)
                {
                    operatorsOff = actualOperators - operatorRequired;
                }
                else
                {
                    operatorsOff = 0;
                }

                dgvInitialTable.Rows[6].Cells[i].Value = operatorsOff ; 
            }
        }

        private void operatorsUsed()
        {
            double operatorsUsed = 0;
            double actualOperators = 0;
            double operatorsHired = 0;
            double operatorsOff = 0;

            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                actualOperators = Convert.ToDouble(dgvInitialTable.Rows[4].Cells[i].Value);
                operatorsHired = Convert.ToDouble(dgvInitialTable.Rows[5].Cells[i].Value);
                operatorsOff = Convert.ToDouble(dgvInitialTable.Rows[6].Cells[i].Value);
                operatorsUsed = ((actualOperators+ operatorsHired)-operatorsOff);

                dgvInitialTable.Rows[7].Cells[i].Value = operatorsUsed;
                
            }
        }
        private void unitsProduced()
        {
            double unitsProduced = 0;
            double unitsPerOperator = 0;
            double operatorsUsed = 0;

            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                unitsPerOperator = Convert.ToDouble(dgvInitialTable.Rows[2].Cells[i].Value);
                operatorsUsed = Convert.ToDouble(dgvInitialTable.Rows[7].Cells[i].Value);

                unitsProduced = unitsPerOperator * operatorsUsed;

                dgvInitialTable.Rows[8].Cells[i].Value = unitsProduced;
            }
        }

        private void unitsAvailable()
        {
            double unitsAvailable = 0;
            double unitsProduced = 0;
            double inventary = 0;

            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                if (i == 1)
                {
                    unitsProduced = Convert.ToDouble(dgvInitialTable.Rows[8].Cells[i].Value);
                    unitsAvailable = unitsProduced + initialInventory;

                    dgvInitialTable.Rows[9].Cells[i].Value = unitsAvailable;
                }
                else
                {
                    unitsProduced = Convert.ToDouble(dgvInitialTable.Rows[8].Cells[i].Value);
                    inventary = Convert.ToDouble(dgvInitialTable.Rows[10].Cells[i-1].Value);

                    unitsAvailable = unitsProduced + inventary;

                    dgvInitialTable.Rows[9].Cells[i].Value = unitsAvailable;
                }
            }
        }

        private void inventory()
        {
            double inventory= 0;
            double unitsAvailable = 0;
            double demand = 0;


            for (int i = 1; i < dgvInitialTable.ColumnCount - 1; i++)
            {
                unitsAvailable = Convert.ToDouble(dgvInitialTable.Rows[9].Cells[i].Value);
                demand = Convert.ToDouble(dgvInitialTable.Rows[1].Cells[i].Value);

                if ( unitsAvailable > demand)
                {
                    inventory = unitsAvailable - demand;

                }
                else
                {
                    inventory = 0;
                }

                dgvInitialTable.Rows[10].Cells[i].Value = inventory;
            }
            
        }

        private void missingUnits()
        {

        }

    }

        
}
