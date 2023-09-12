using Microsoft.VisualStudio.TextManager.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggregate_Planing.Views
{
 
    public partial class InitialCatalog : Form
    {
        private Form activeForm;
      
        public InitialCatalog()
        {
            InitializeComponent();
            this.Text = String.Empty;
         
       
        }

        
        private void InitialCatalog_Load(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm , object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(childForm);
            this.pnlContainer.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;

        }

        private void btnPlaning_Click(object sender, EventArgs e)
        {
            DateSelector dateSelector = new DateSelector();
            dateSelector.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPlans viewPlans = new ViewPlans();  
            viewPlans.Show();
        }
    }
}
