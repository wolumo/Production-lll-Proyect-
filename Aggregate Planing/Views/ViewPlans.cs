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
        }
    }
}
