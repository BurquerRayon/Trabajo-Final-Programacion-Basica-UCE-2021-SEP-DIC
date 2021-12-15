
namespace Proyecto_final
{
    partial class FN4
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
            this.TB2FN4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB2FN4
            // 
            this.TB2FN4.Location = new System.Drawing.Point(59, 53);
            this.TB2FN4.Name = "TB2FN4";
            this.TB2FN4.Size = new System.Drawing.Size(265, 22);
            this.TB2FN4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introducir Fecha (xx/xx/xxxx):";
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(130, 93);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(110, 66);
            this.B4.TabIndex = 4;
            this.B4.Text = "Buscar";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // FN4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 205);
            this.Controls.Add(this.TB2FN4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B4);
            this.Name = "FN4";
            this.Text = "FN4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB2FN4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B4;
    }
}