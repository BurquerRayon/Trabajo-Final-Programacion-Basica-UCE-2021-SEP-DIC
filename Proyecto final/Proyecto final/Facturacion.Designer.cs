
namespace Proyecto_final
{
    partial class Facturacion
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
            this.U1 = new System.Windows.Forms.Button();
            this.U2 = new System.Windows.Forms.Button();
            this.U3 = new System.Windows.Forms.Button();
            this.U4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // U1
            // 
            this.U1.Location = new System.Drawing.Point(38, 25);
            this.U1.Name = "U1";
            this.U1.Size = new System.Drawing.Size(138, 87);
            this.U1.TabIndex = 0;
            this.U1.Text = "Ventas Diarias";
            this.U1.UseVisualStyleBackColor = true;
            this.U1.Click += new System.EventHandler(this.U1_Click);
            // 
            // U2
            // 
            this.U2.Location = new System.Drawing.Point(228, 25);
            this.U2.Name = "U2";
            this.U2.Size = new System.Drawing.Size(138, 87);
            this.U2.TabIndex = 1;
            this.U2.Text = "Pagos Realizados";
            this.U2.UseVisualStyleBackColor = true;
            this.U2.Click += new System.EventHandler(this.U2_Click);
            // 
            // U3
            // 
            this.U3.Location = new System.Drawing.Point(38, 152);
            this.U3.Name = "U3";
            this.U3.Size = new System.Drawing.Size(138, 87);
            this.U3.TabIndex = 2;
            this.U3.Text = "Coordinaciones de pago";
            this.U3.UseVisualStyleBackColor = true;
            this.U3.Click += new System.EventHandler(this.U3_Click);
            // 
            // U4
            // 
            this.U4.Location = new System.Drawing.Point(228, 152);
            this.U4.Name = "U4";
            this.U4.Size = new System.Drawing.Size(138, 87);
            this.U4.TabIndex = 3;
            this.U4.Text = "Buscar Facturas";
            this.U4.UseVisualStyleBackColor = true;
            this.U4.Click += new System.EventHandler(this.U4_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 284);
            this.Controls.Add(this.U4);
            this.Controls.Add(this.U3);
            this.Controls.Add(this.U2);
            this.Controls.Add(this.U1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button U1;
        private System.Windows.Forms.Button U2;
        private System.Windows.Forms.Button U3;
        private System.Windows.Forms.Button U4;
    }
}