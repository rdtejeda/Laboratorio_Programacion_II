namespace FormPrincipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.tBxKilometros = new System.Windows.Forms.TextBox();
            this.tBxLitros = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(44, 26);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(64, 15);
            this.lblKilometros.TabIndex = 0;
            this.lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(44, 106);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(36, 15);
            this.lblLitros.TabIndex = 1;
            this.lblLitros.Text = "Litros";
            // 
            // tBxKilometros
            // 
            this.tBxKilometros.Location = new System.Drawing.Point(44, 57);
            this.tBxKilometros.Name = "tBxKilometros";
            this.tBxKilometros.Size = new System.Drawing.Size(100, 23);
            this.tBxKilometros.TabIndex = 2;
            // 
            // tBxLitros
            // 
            this.tBxLitros.Location = new System.Drawing.Point(44, 143);
            this.tBxLitros.Name = "tBxLitros";
            this.tBxLitros.Size = new System.Drawing.Size(100, 23);
            this.tBxLitros.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(172, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(118, 194);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(44, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 58);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 308);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tBxLitros);
            this.Controls.Add(this.tBxKilometros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 347);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox tBxKilometros;
        private System.Windows.Forms.TextBox tBxLitros;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCalcular;
    }
}
