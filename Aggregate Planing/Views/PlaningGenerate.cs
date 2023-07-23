﻿using System;
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
            dgvInitialTable.ClearSelection();
            dgvRequiredData.ClearSelection();
            dgvPlanCost.ClearSelection();
            
            

           
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


            for (int i = 2; i < dgvInitialTable.RowCount; i++)
            {


                
                    DataGridViewRow row = dgvInitialTable.Rows[i];

                    row.DefaultCellStyle.BackColor = Color.Gray;
                   
                    row.DefaultCellStyle.SelectionBackColor = Color.Gray;
                 

                    row.DefaultCellStyle.Font = new Font(dgvInitialTable.Font, FontStyle.Italic);
                    row.ReadOnly = true;

            }
            DataGridViewColumn column = dgvInitialTable.Columns[dgvInitialTable.ColumnCount-1];
            column.DefaultCellStyle.BackColor = Color.Gray;
            column.ReadOnly = true;
            dgvInitialTable.AllowUserToAddRows = false;

            dgvInitialTable.Rows[0].Cells[0].ReadOnly = true;
            dgvInitialTable.Rows[1].Cells[0].ReadOnly = true;

            dgvInitialTable.AllowUserToOrderColumns = false;
            dgvInitialTable.AllowUserToResizeColumns = false;
            dgvInitialTable.AllowUserToDeleteRows = false;
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

            dgvRequiredData.AllowUserToAddRows = false;

            for (int i = 0; i < dgvRequiredData.RowCount; i++)
            {
                dgvRequiredData.Rows[i].Cells[0].ReadOnly = true;
                dgvRequiredData.Rows[i].Cells[2].ReadOnly = true;
            }

            dgvRequiredData.AllowUserToDeleteRows=false;
            dgvRequiredData.AllowUserToOrderColumns=false;
            dgvRequiredData.AllowUserToResizeColumns = false;
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

            for (int i = 0; i < dgvPlanCost.RowCount; i++)
            {



                DataGridViewRow row = dgvPlanCost.Rows[i];

                row.DefaultCellStyle.BackColor = Color.Gray;

                row.DefaultCellStyle.SelectionBackColor = Color.Gray;


                row.DefaultCellStyle.Font = new Font(dgvPlanCost.Font, FontStyle.Italic);
                row.ReadOnly = true;

            }
            dgvPlanCost.AllowUserToAddRows = false;
            dgvPlanCost.AllowUserToDeleteRows=false;

        }

        private void SumCalculate()
        {
            double totalSum = 0;
            double value = 0;
           

            for (int e = 0; e < dgvInitialTable.RowCount; e++)
            {
                if (e ==3)
                {
                   
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

       

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DefaultDgvStyle();
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
            missingUnits();
            SumCalculate();

            //DgvCostMethods;
            costToHire();
            costToLayingOff();
            costToLabour();
            CostToStore();
            costForShortages();
            TotalCostPlaning();
            SumCalculateCost();

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
            double demand = 0;
            double unitsAvailable = 0;
            double missingUnits = 0;

            for (int i = 1; i < dgvInitialTable.ColumnCount-1; i++)
            {
                demand = Convert.ToDouble(dgvInitialTable.Rows[1].Cells[i].Value);
                unitsAvailable = Convert.ToDouble(dgvInitialTable.Rows[9].Cells[i].Value);

                if (demand > unitsAvailable)
                {
                    missingUnits = demand - unitsAvailable;
                }
                else
                {
                    missingUnits = 0;
                }
                dgvInitialTable.Rows[11].Cells[i].Value = missingUnits;

            }
        }

        private void costToHire()
        {
            double operatorsHired = 0;
            double costToHire = 0;

            for (int i = 1; i < dgvPlanCost.ColumnCount-1; i++)
            {
                operatorsHired = Convert.ToDouble(dgvInitialTable.Rows[5].Cells[i].Value);

                costToHire = operatorsHired * costOfHiring;

                dgvPlanCost.Rows[0].Cells[i].Value = costToHire;
            }
        }

        private void costToLayingOff()
        {
            double operatorsDismiss=0;
            double costToLayingOff = 0;

            for (int i = 1; i < dgvPlanCost.ColumnCount-1; i++)
            {
                operatorsDismiss = Convert.ToDouble(dgvInitialTable.Rows[6].Cells[i].Value);

                costToLayingOff = operatorsDismiss * costOfDismissing;

                dgvPlanCost.Rows[1].Cells[i].Value = costToLayingOff;
            }
        }

        private void costToLabour()
        {
            double operatorsUsed = 0;
            double daysWork = 0;
            double costTolabour = 0;

            for (int i = 1; i < dgvPlanCost.ColumnCount-1; i++)
            {
                operatorsUsed = Convert.ToDouble(dgvInitialTable.Rows[7].Cells[i].Value) ;
                daysWork = Convert.ToDouble(dgvInitialTable.Rows[0].Cells[i].Value);

                costTolabour =  operatorsUsed * daysWork * dailyCosPerOver;

                dgvPlanCost.Rows[2].Cells[i].Value = costTolabour;
            }
        }

        private void CostToStore()
        {
            double inventory = 0;
            double costToStors = 0;

            for (int i = 1; i < dgvPlanCost.ColumnCount-1; i++)
            {
                inventory = Convert.ToDouble(dgvInitialTable.Rows[10].Cells[i].Value);

                costToStors = inventory * costToStore;

                dgvPlanCost.Rows[3].Cells[i].Value = costToStors;
            }
            
        }

        private void costForShortages()
        {
            double costForShortages = 0;
            double missingUnits = 0;

            for (int i = 1; i < dgvPlanCost.ColumnCount-1; i++)
            {
                missingUnits = Convert.ToDouble(dgvInitialTable.Rows[11].Cells[i].Value);
                costForShortages = missingUnits * shortageCost; 

                dgvPlanCost.Rows[4].Cells[i].Value = costForShortages;
            }
        }

        private void TotalCostPlaning()
        {
            double totalCost = 0;

            for (int i = 1; i < dgvPlanCost.ColumnCount-1; i++)
            {
                for (int k = 0; k < dgvPlanCost.RowCount-1; k++)
                {
                    totalCost +=Convert.ToDouble(dgvPlanCost.Rows[k].Cells[i].Value);
                }
                dgvPlanCost.Rows[5].Cells[i].Value = totalCost;
                totalCost = 0;
            }
        }

        private void SumCalculateCost()
        {
            double totalSum = 0;
            double value = 0;


            for (int e = 0; e < dgvPlanCost.RowCount; e++)
            {
                Console.WriteLine(dgvPlanCost.ColumnCount);
                    for (int i = 1; i < dgvPlanCost.ColumnCount; i++)
                    {
                        if (i == dgvPlanCost.ColumnCount-1)
                        {
                            dgvPlanCost.Rows[e].Cells[dgvPlanCost.ColumnCount-1].Value = totalSum;
                            totalSum = 0;
                        }
                        else
                        {
                            value = Convert.ToDouble(dgvPlanCost.Rows[e].Cells[i].Value);
                            totalSum += value;
                        }
                    }
                
            }


        }

        //private void dgvInitialTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
            
            



        //}

        private void DefaultDgvStyle()
        {
            dgvInitialTable.ClearSelection();

            foreach (DataGridViewRow row in dgvInitialTable.Rows)
            {
                row.DefaultCellStyle.BackColor = dgvInitialTable.DefaultCellStyle.BackColor;
               

            }

            dgvPlanCost.ClearSelection();

            foreach (DataGridViewRow row in dgvPlanCost.Rows)
            {
                row.DefaultCellStyle.BackColor = dgvPlanCost.DefaultCellStyle.BackColor;
             
            }
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

            dgvInitialTable.Rows.Clear();
            dgvPlanCost.Rows.Clear();
            dgvRequiredData.Rows.Clear();
            ChargeInitialDgv();
            ChargeRequiredDataDgv();
            ChargeCostDgv();
        }

      

        //private void dgvInitialTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
        //    {
        //        string inputValue = dgvInitialTable.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

        //        if (inputValue == "")
        //        {
        //            return;
        //        }

        //        if (e.ColumnIndex == 0)
        //        {
        //            return;
        //        }

        //        if (!double.TryParse(inputValue, out double result))
        //        {
        //            MessageBox.Show("Por favor, solo ingrese números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            // Cambiar el valor de la celda a vacío (""), ya que la validación ha fallado
        //            dgvInitialTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
        //        }
        //    }
        //}

        private void dgvInitialTable_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string inputValue = e.FormattedValue.ToString();

            if (inputValue =="")
            {
                return;
            }

            if (e.ColumnIndex ==0)
            {
                return;
            }

            if (!double.TryParse(inputValue, out double result))
            {

                MessageBox.Show("Por favor, solo ingrese numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Cancel =true;

            }
        }

        private void dgvRequiredData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string inputValue = e.FormattedValue.ToString();

            if (inputValue =="")
            {
                return;
            }

            if (e.ColumnIndex ==0 || e.ColumnIndex == 2)
            {
                return;
            }

            if (!double.TryParse(inputValue, out double result))
            {

                MessageBox.Show("Por favor, solo ingrese numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Cancel =true;

            }

        }

        private void dgvInitialTable_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            
        }

        private void dgvInitialTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgvRequiredData_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }

        
}
