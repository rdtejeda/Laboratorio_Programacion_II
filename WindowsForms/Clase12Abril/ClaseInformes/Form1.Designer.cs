namespace ClaseInformes
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
            this.btnNuevoFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoFormulario
            // 
            this.btnNuevoFormulario.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoFormulario.Location = new System.Drawing.Point(210, 12);
            this.btnNuevoFormulario.Name = "btnNuevoFormulario";
            this.btnNuevoFormulario.Size = new System.Drawing.Size(157, 111);
            this.btnNuevoFormulario.TabIndex = 0;
            this.btnNuevoFormulario.Text = "Cargar Formulario";
            this.btnNuevoFormulario.UseVisualStyleBackColor = true;
            this.btnNuevoFormulario.Click += new System.EventHandler(this.btnNuevoFormulario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.btnNuevoFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Roberto!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoFormulario;
    }
}
