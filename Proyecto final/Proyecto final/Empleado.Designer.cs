
namespace Proyecto_final
{
    partial class Empleado
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
            this.lblU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(12, 9);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(0, 17);
            this.lblU.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 52);
            this.button8.TabIndex = 19;
            this.button8.Text = "Perfil";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 52);
            this.button3.TabIndex = 14;
            this.button3.Text = "Facturacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reportes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 161);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblU);
            this.Name = "Empleado";
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}