using Aggregate_Planing.Controller;
using Aggregate_Planing.Model;
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
    public partial class ViewPlans : Form
    {
        int caseOpc;
        public ViewPlans()
        {
            InitializeComponent();
            chargeDataGridPlans();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chargeDataGridPlans()
        {
            dgvPlans.AutoGenerateColumns = false;
            chargeSeletedColumns();
            AggreggationPlanController planController = new AggreggationPlanController();
            List<AgreggationPlan> plans = planController.showPlans();
            dgvPlans.DataSource = plans;
        }

        private void chargeSeletedColumns()
        {
            dgvPlans.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idPlan",
                HeaderText = "ID"
            });
            dgvPlans.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NamePlan",
                HeaderText = "Nombre Del Plan"
            });
            dgvPlans.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedDateTime",
                HeaderText = "Fecha de Creacion"
            });
            //Adding buttons to edit, delete, and Read

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
            {
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                HeaderText = "Editar",
                Name = "EditarButtonColumn"
            };
            DataGridViewButtonColumn vizualiceColumn = new DataGridViewButtonColumn
            {
                Text = "Visualizar",
                UseColumnTextForButtonValue = true,
                HeaderText = "Visualizar",
                Name = "VisualizarButtonColumn"
            };
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                HeaderText = "Eliminar",
                Name = "EliminarButtonColumn"
            };

            dgvPlans.Columns.Add(editColumn);
            dgvPlans.Columns.Add(vizualiceColumn);
            dgvPlans.Columns.Add(deleteColumn);

        }

        private void dgvPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) //Validating if the user clickes on the Data Grid View
            {
                if(e.ColumnIndex == dgvPlans.Columns["EditarButtonColumn"].Index)
                {
                    caseOpc = 1; // Means Edit
                    int id = (int)dgvPlans.Rows[e.RowIndex].Cells[0].Value;
                    PlaningGenerate planingGenerate = new PlaningGenerate();
                    planingGenerate.PlanningCase(id, caseOpc);
                   
                  


                }
                if(e.ColumnIndex == dgvPlans.Columns["VisualizarButtonColumn"].Index)
                {
                    int id = (int)dgvPlans.Rows[e.RowIndex].Cells["Id"].Value;
                }
                if(e.ColumnIndex == dgvPlans.Columns["EliminarButtonColumn"].Index)
                {
                    int id = (int)dgvPlans.Rows[e.RowIndex].Cells["Id"].Value;
                }

            }
        }
    }
}
