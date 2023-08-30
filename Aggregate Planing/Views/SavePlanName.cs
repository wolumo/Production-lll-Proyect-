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
        public ManualResetEventSlim syncEvent;
        public string planName { get; set; }
        public PlaningGenerate planingGenerate = new PlaningGenerate();
        public SavePlanName()
        {
            InitializeComponent();
            // syncEvent = planingGenerate.syncEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            planName = txtNombre.Text;
            //syncEvent.Set();
            this.Close();

        }

        public string getNamePlan()
        {
            return planName;
        }

        private void SavePlanName_Load(object sender, EventArgs e)
        {

        }
    }
}
