namespace Aggregate_Planing.Views
{
    partial class InitialCatalog
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
            this.NavigatorPanel = new System.Windows.Forms.Panel();
            this.btnPlaning = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.NavigatorPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigatorPanel
            // 
            this.NavigatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.NavigatorPanel.Controls.Add(this.btnPlaning);
            this.NavigatorPanel.Controls.Add(this.panelLogo);
            this.NavigatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigatorPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigatorPanel.Name = "NavigatorPanel";
            this.NavigatorPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NavigatorPanel.Size = new System.Drawing.Size(220, 536);
            this.NavigatorPanel.TabIndex = 0;
            // 
            // btnPlaning
            // 
            this.btnPlaning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaning.FlatAppearance.BorderSize = 0;
            this.btnPlaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlaning.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaning.Image = global::Aggregate_Planing.Properties.Resources.plan_estrategico1;
            this.btnPlaning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaning.Location = new System.Drawing.Point(0, 80);
            this.btnPlaning.Name = "btnPlaning";
            this.btnPlaning.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnPlaning.Size = new System.Drawing.Size(220, 60);
            this.btnPlaning.TabIndex = 1;
            this.btnPlaning.Text = "      Plan Agregado";
            this.btnPlaning.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPlaning.UseVisualStyleBackColor = true;
            this.btnPlaning.Click += new System.EventHandler(this.btnPlaning_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lbl);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.lblHome);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(700, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(297, 30);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(68, 25);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.Color.LightGray;
            this.lbl.Location = new System.Drawing.Point(12, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(185, 21);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Programa Plan Agregado";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(220, 80);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(700, 456);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // InitialCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 536);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.NavigatorPanel);
            this.Name = "InitialCatalog";
            this.Text = "InitialCatalog";
            this.Load += new System.EventHandler(this.InitialCatalog_Load);
            this.NavigatorPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavigatorPanel;
        private Button btnPlaning;
        private Panel panelLogo;
        private Panel panelTitle;
        private Label lblHome;
        private Label lbl;
        private Panel pnlContainer;
    }
}