namespace WFClase20Abill
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
            this.richTexto = new System.Windows.Forms.RichTextBox();
            this.buttCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTexto
            // 
            this.richTexto.Location = new System.Drawing.Point(164, 22);
            this.richTexto.Name = "richTexto";
            this.richTexto.Size = new System.Drawing.Size(263, 363);
            this.richTexto.TabIndex = 0;
            this.richTexto.Text = "";
            // 
            // buttCalcular
            // 
            this.buttCalcular.Location = new System.Drawing.Point(12, 22);
            this.buttCalcular.Name = "buttCalcular";
            this.buttCalcular.Size = new System.Drawing.Size(116, 53);
            this.buttCalcular.TabIndex = 1;
            this.buttCalcular.Text = "Calcular";
            this.buttCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.buttCalcular);
            this.Controls.Add(this.richTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTexto;
        private System.Windows.Forms.Button buttCalcular;
    }
}
