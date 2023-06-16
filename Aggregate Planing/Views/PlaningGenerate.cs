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

        string[] months = new string[]{
        "Enero", "Febrero", "Marzo", "Abril", "Mayo",
        "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
        "Noviembre", "Diciembre"};

        string[] InitialRows = new string[]
        {
            "Dias laborales", "Demanda" , "Unidades por operario" , "Operarios Requeridos", "Operarios Actuales",
            "Operarios Contratados", "Operarios Despedidos" , "Operarios Utilizados" , "Unidades Producidas" , "Unidades Disponibles",
            "Inventario", "Unidades Faltantes"
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
        }

        private void ChargeInitialDgv()
        {
            Console.WriteLine("Este es el load");
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
    }
}
