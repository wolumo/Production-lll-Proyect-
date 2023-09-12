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
    public partial class SavePlanName : Form
    {
     
        public string planName { get; set; }
  
        
        public SavePlanName()
        {
            InitializeComponent();
            // syncEvent = planingGenerate.syncEvent;
        }

    

        public string getNamePlan()
        {
            return planName;
        }

        private void SavePlanName_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Tiene que insertar un nombre del plan!");
                return;
            }
            else
            {
                planName = txtNombre.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
