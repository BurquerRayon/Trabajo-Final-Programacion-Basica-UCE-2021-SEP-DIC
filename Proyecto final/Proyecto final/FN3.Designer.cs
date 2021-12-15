
namespace Proyecto_final
{
    partial class FN3
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
            this.TBFN1 = new System.Windows.Forms.TextBox();
            this.TBFN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.TB1FN3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.B3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBFN1
            // 
            this.TBFN1.Location = new System.Drawing.Point(47, 48);
            this.TBFN1.Name = "TBFN1";
            this.TBFN1.Size = new System.Drawing.Size(268, 22);
            this.TBFN1.TabIndex = 14;
            // 
            // TBFN2
            // 
            this.TBFN2.Location = new System.Drawing.Point(50, 105);
            this.TBFN2.Name = "TBFN2";
            this.TBFN2.Size = new System.Drawing.Size(265, 22);
            this.TBFN2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Introducir Fecha (xx/xx/xxxx):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Introducir Nombre o Codigo del producto:";
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(0, 0);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 0;
            // 
            // TB1FN3
            // 
            this.TB1FN3.Location = new System.Drawing.Point(34, 60);
            this.TB1FN3.Name = "TB1FN3";
            this.TB1FN3.Size = new System.Drawing.Size(268, 22);
            this.TB1FN3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Introducir Nombre o Codigo del producto:";
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(107, 102);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(101, 51);
            this.B3.TabIndex = 15;
            this.B3.Text = "Buscar";
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // FN3
            // 
            this.ClientSize = new System.Drawing.Size(336, 224);
            this.Controls.Add(this.TB1FN3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B3);
            this.Name = "FN3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBFN1;
        private System.Windows.Forms.TextBox TBFN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox TB1FN3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B3;
    }
}