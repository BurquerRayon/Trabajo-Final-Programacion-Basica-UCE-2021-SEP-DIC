
namespace Proyecto_final
{
    partial class FAC1
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
            this.TB1FAC1 = new System.Windows.Forms.TextBox();
            this.B1B1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB1FAC1
            // 
            this.TB1FAC1.Location = new System.Drawing.Point(3, 43);
            this.TB1FAC1.Name = "TB1FAC1";
            this.TB1FAC1.Size = new System.Drawing.Size(296, 22);
            this.TB1FAC1.TabIndex = 0;
            // 
            // B1B1
            // 
            this.B1B1.Location = new System.Drawing.Point(83, 71);
            this.B1B1.Name = "B1B1";
            this.B1B1.Size = new System.Drawing.Size(127, 66);
            this.B1B1.TabIndex = 5;
            this.B1B1.Text = "Buscar";
            this.B1B1.UseVisualStyleBackColor = true;
            this.B1B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese una Fecha (XX/XX/XXXX):";
            // 
            // FAC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB1FAC1);
            this.Controls.Add(this.B1B1);
            this.Name = "FAC1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1FAC1;
        private System.Windows.Forms.Button B1B1;
        private System.Windows.Forms.Label label2;
    }
}