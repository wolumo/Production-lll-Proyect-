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
    public partial class DateSelector : Form
    {
        public DateSelector()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool Indicator;
            int InitialMonth = cmbFrom.SelectedIndex;
            int FinalMonth = cmbTo.SelectedIndex;
            Indicator = validateMonths(InitialMonth, FinalMonth);

            if (Indicator)
            {
                PlaningGenerate planing = new PlaningGenerate(InitialMonth, FinalMonth);
                planing.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El Mes de Inicio no debe ser Mayor que El final");
                return;
            }
            
        }

        private bool validateMonths(int InitialMonth, int FinalMonth)
        {
            bool Indicator;
            if(InitialMonth > FinalMonth)
            {
                Indicator = false;
            }
            else
            {
                Indicator = true;
            }

            return Indicator;
        }
        
    }
}
