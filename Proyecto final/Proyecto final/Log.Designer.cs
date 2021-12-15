
namespace Proyecto_final
{
    partial class Log
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
            this.IP1 = new System.Windows.Forms.Button();
            this.US = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(113, 149);
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(149, 60);
            this.IP1.TabIndex = 0;
            this.IP1.Text = "Iniciar Sesion";
            this.IP1.UseVisualStyleBackColor = true;
            this.IP1.Click += new System.EventHandler(this.IP1_Click);
            // 
            // US
            // 
            this.US.Location = new System.Drawing.Point(164, 42);
            this.US.Name = "US";
            this.US.Size = new System.Drawing.Size(149, 22);
            this.US.TabIndex = 1;
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(164, 97);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(149, 22);
            this.Contra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.US);
            this.Controls.Add(this.IP1);
            this.Name = "Log";
            this.Text = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IP1;
        private System.Windows.Forms.TextBox US;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}