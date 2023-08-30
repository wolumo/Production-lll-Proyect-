namespace Aggregate_Planing.Views
{
    partial class SavePlanName
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
            label1=new Label();
            txtNombre=new TextBox();
            button1=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(24, 23);
            label1.Name="label1";
            label1.Size=new Size(77, 21);
            label1.TabIndex=0;
            label1.Text="Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location=new Point(107, 25);
            txtNombre.Name="txtNombre";
            txtNombre.Size=new Size(495, 23);
            txtNombre.TabIndex=1;
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(527, 54);
            button1.Name="button1";
            button1.Size=new Size(75, 23);
            button1.TabIndex=2;
            button1.Text="Guardar";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // SavePlanName
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(614, 92);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name="SavePlanName";
            Text="SavePlanNanme";
            Load+=SavePlanName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button button1;
    }
}