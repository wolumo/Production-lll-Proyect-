namespace Aggregate_Planing.Views
{
    partial class PlaningGenerate
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
            this.dgvInitialTable = new System.Windows.Forms.DataGridView();
            this.dgvRequiredData = new System.Windows.Forms.DataGridView();
            this.dgvPlanCost = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequiredData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanCost)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInitialTable
            // 
            this.dgvInitialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialTable.Location = new System.Drawing.Point(30, 34);
            this.dgvInitialTable.Name = "dgvInitialTable";
            this.dgvInitialTable.RowTemplate.Height = 25;
            this.dgvInitialTable.Size = new System.Drawing.Size(594, 381);
            this.dgvInitialTable.TabIndex = 0;
            this.dgvInitialTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInitialTable_CellValueChanged);
            // 
            // dgvRequiredData
            // 
            this.dgvRequiredData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequiredData.Location = new System.Drawing.Point(715, 34);
            this.dgvRequiredData.Name = "dgvRequiredData";
            this.dgvRequiredData.RowTemplate.Height = 25;
            this.dgvRequiredData.Size = new System.Drawing.Size(362, 381);
            this.dgvRequiredData.TabIndex = 1;
            // 
            // dgvPlanCost
            // 
            this.dgvPlanCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanCost.Location = new System.Drawing.Point(34, 450);
            this.dgvPlanCost.Name = "dgvPlanCost";
            this.dgvPlanCost.RowTemplate.Height = 25;
            this.dgvPlanCost.Size = new System.Drawing.Size(590, 293);
            this.dgvPlanCost.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(715, 450);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 36);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(907, 450);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(170, 36);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar Tablas";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // PlaningGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 784);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dgvPlanCost);
            this.Controls.Add(this.dgvRequiredData);
            this.Controls.Add(this.dgvInitialTable);
            this.Name = "PlaningGenerate";
            this.Text = "PlaningGenerate";
            this.Load += new System.EventHandler(this.PlaningGenerate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequiredData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvInitialTable;
        private DataGridView dgvRequiredData;
        private DataGridView dgvPlanCost;
        private Button btnCalculate;
        private Button btnClean;
    }
}