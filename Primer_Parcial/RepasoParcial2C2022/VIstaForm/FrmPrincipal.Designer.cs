namespace VIstaForm
{
    partial class FrmPrincipal
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
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.rtbDetalle = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(583, 11);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(205, 42);
            this.btnVerDatos.TabIndex = 0;
            this.btnVerDatos.Text = "Ver datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // rtbDetalle
            // 
            this.rtbDetalle.Location = new System.Drawing.Point(12, 59);
            this.rtbDetalle.Name = "rtbDetalle";
            this.rtbDetalle.Size = new System.Drawing.Size(776, 379);
            this.rtbDetalle.TabIndex = 1;
            this.rtbDetalle.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDetalle);
            this.Controls.Add(this.btnVerDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.RichTextBox rtbDetalle;
    }
}
