
namespace Proyecto_final
{
    partial class FAC3
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
            this.BFAC3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB3FAC1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BFAC3
            // 
            this.BFAC3.Location = new System.Drawing.Point(92, 105);
            this.BFAC3.Name = "BFAC3";
            this.BFAC3.Size = new System.Drawing.Size(108, 54);
            this.BFAC3.TabIndex = 0;
            this.BFAC3.Text = "Buscar";
            this.BFAC3.UseVisualStyleBackColor = true;
            this.BFAC3.Click += new System.EventHandler(this.BFAC3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el tipo de pago:";
            // 
            // TB3FAC1
            // 
            this.TB3FAC1.Location = new System.Drawing.Point(46, 66);
            this.TB3FAC1.Name = "TB3FAC1";
            this.TB3FAC1.Size = new System.Drawing.Size(205, 22);
            this.TB3FAC1.TabIndex = 2;
            // 
            // FAC3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 211);
            this.Controls.Add(this.TB3FAC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFAC3);
            this.Name = "FAC3";
            this.Load += new System.EventHandler(this.FAC3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BFAC3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB3FAC1;
    }
}