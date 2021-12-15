
namespace Proyecto_final
{
    partial class FAC4
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
            this.P = new System.Windows.Forms.Label();
            this.TB4FAC1 = new System.Windows.Forms.TextBox();
            this.B1B2 = new System.Windows.Forms.Button();
            this.P3 = new System.Windows.Forms.Label();
            this.TB4FAC3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(12, 11);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(130, 17);
            this.P.TabIndex = 14;
            this.P.Text = "Ingrese una Fecha:";
            // 
            // TB4FAC1
            // 
            this.TB4FAC1.Location = new System.Drawing.Point(12, 31);
            this.TB4FAC1.Name = "TB4FAC1";
            this.TB4FAC1.Size = new System.Drawing.Size(296, 22);
            this.TB4FAC1.TabIndex = 12;
            // 
            // B1B2
            // 
            this.B1B2.Location = new System.Drawing.Point(88, 134);
            this.B1B2.Name = "B1B2";
            this.B1B2.Size = new System.Drawing.Size(127, 66);
            this.B1B2.TabIndex = 13;
            this.B1B2.Text = "Buscar";
            this.B1B2.UseVisualStyleBackColor = true;
            this.B1B2.Click += new System.EventHandler(this.B1B2_Click);
            // 
            // P3
            // 
            this.P3.AutoSize = true;
            this.P3.Location = new System.Drawing.Point(9, 71);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(194, 17);
            this.P3.TabIndex = 19;
            this.P3.Text = "Ingrese el nombre del cliente:";
            // 
            // TB4FAC3
            // 
            this.TB4FAC3.Location = new System.Drawing.Point(12, 91);
            this.TB4FAC3.Name = "TB4FAC3";
            this.TB4FAC3.Size = new System.Drawing.Size(296, 22);
            this.TB4FAC3.TabIndex = 17;
            // 
            // FAC4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 236);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.TB4FAC3);
            this.Controls.Add(this.P);
            this.Controls.Add(this.TB4FAC1);
            this.Controls.Add(this.B1B2);
            this.Name = "FAC4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.TextBox TB4FAC1;
        private System.Windows.Forms.Button B1B2;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.TextBox TB4FAC3;
    }
}