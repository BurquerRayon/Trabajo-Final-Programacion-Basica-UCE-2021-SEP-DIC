
namespace Proyecto_final
{
    partial class FAC2
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
            this.L = new System.Windows.Forms.Label();
            this.TB2FAC1 = new System.Windows.Forms.TextBox();
            this.B1B2 = new System.Windows.Forms.Button();
            this.L2 = new System.Windows.Forms.Label();
            this.TB2FAC2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(12, 11);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(130, 17);
            this.L.TabIndex = 9;
            this.L.Text = "Ingrese una Fecha:";
            // 
            // TB2FAC1
            // 
            this.TB2FAC1.Location = new System.Drawing.Point(12, 31);
            this.TB2FAC1.Name = "TB2FAC1";
            this.TB2FAC1.Size = new System.Drawing.Size(296, 22);
            this.TB2FAC1.TabIndex = 7;
            // 
            // B1B2
            // 
            this.B1B2.Location = new System.Drawing.Point(89, 112);
            this.B1B2.Name = "B1B2";
            this.B1B2.Size = new System.Drawing.Size(127, 66);
            this.B1B2.TabIndex = 8;
            this.B1B2.Text = "Buscar";
            this.B1B2.UseVisualStyleBackColor = true;
            this.B1B2.Click += new System.EventHandler(this.B1B2_Click);
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(12, 64);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(211, 17);
            this.L2.TabIndex = 11;
            this.L2.Text = "Ingrese el nombre del Receptor:";
            // 
            // TB2FAC2
            // 
            this.TB2FAC2.Location = new System.Drawing.Point(12, 84);
            this.TB2FAC2.Name = "TB2FAC2";
            this.TB2FAC2.Size = new System.Drawing.Size(296, 22);
            this.TB2FAC2.TabIndex = 10;
            // 
            // FAC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 217);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.TB2FAC2);
            this.Controls.Add(this.L);
            this.Controls.Add(this.TB2FAC1);
            this.Controls.Add(this.B1B2);
            this.Name = "FAC2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L;
        private System.Windows.Forms.TextBox TB2FAC1;
        private System.Windows.Forms.Button B1B2;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox TB2FAC2;
    }
}