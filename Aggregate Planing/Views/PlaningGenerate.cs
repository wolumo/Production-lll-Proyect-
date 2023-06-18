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
        //private double total;
        //private bool updatingTotal = false;

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
    }
}
