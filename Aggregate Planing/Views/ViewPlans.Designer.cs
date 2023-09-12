namespace Aggregate_Planing.Views
{
    partial class ViewPlans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.myDBContexrtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBContexrtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planes Agregados Guardados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPlans);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 396);
            this.panel2.TabIndex = 2;
            // 
            // dgvPlans
            // 
            this.dgvPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlans.Location = new System.Drawing.Point(0, 0);
            this.dgvPlans.Name = "dgvPlans";
            this.dgvPlans.RowTemplate.Height = 25;
            this.dgvPlans.Size = new System.Drawing.Size(800, 396);
            this.dgvPlans.TabIndex = 0;
            this.dgvPlans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlans_CellClick);
            // 
            // myDBContexrtBindingSource
            // 
            this.myDBContexrtBindingSource.DataSource = typeof(Aggregate_Planing.Conexion.MyDBContexrt);
            // 
            // ViewPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPlans";
            this.Text = "ViewPlans";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBContexrtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvPlans;
        private BindingSource myDBContexrtBindingSource;
    }
}