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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInitialTable
            // 
            this.dgvInitialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialTable.Location = new System.Drawing.Point(21, 40);
            this.dgvInitialTable.Name = "dgvInitialTable";
            this.dgvInitialTable.RowTemplate.Height = 25;
            this.dgvInitialTable.Size = new System.Drawing.Size(742, 323);
            this.dgvInitialTable.TabIndex = 0;
            // 
            // PlaningGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.dgvInitialTable);
            this.Name = "PlaningGenerate";
            this.Text = "PlaningGenerate";
            this.Load += new System.EventHandler(this.PlaningGenerate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvInitialTable;
    }
}