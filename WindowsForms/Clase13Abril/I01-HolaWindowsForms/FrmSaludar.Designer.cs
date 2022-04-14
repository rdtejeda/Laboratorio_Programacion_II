namespace I01_HolaWindowsForms
{
    partial class FrmI01
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
            this.txtBUno = new System.Windows.Forms.TextBox();
            this.txtBDos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUno = new System.Windows.Forms.Button();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBUno
            // 
            this.txtBUno.Location = new System.Drawing.Point(74, 35);
            this.txtBUno.Name = "txtBUno";
            this.txtBUno.Size = new System.Drawing.Size(100, 23);
            this.txtBUno.TabIndex = 0;
            this.txtBUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBUno.TextChanged += new System.EventHandler(this.txtBUno_TextChanged);
            // 
            // txtBDos
            // 
            this.txtBDos.Location = new System.Drawing.Point(74, 91);
            this.txtBDos.Name = "txtBDos";
            this.txtBDos.Size = new System.Drawing.Size(100, 23);
            this.txtBDos.TabIndex = 1;
            this.txtBDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBDos.UseWaitCursor = true;
            this.txtBDos.TextChanged += new System.EventHandler(this.txtBDos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUno.Location = new System.Drawing.Point(55, 209);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(130, 52);
            this.btnUno.TabIndex = 4;
            this.btnUno.Text = "Saludar";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaterias.Location = new System.Drawing.Point(95, 138);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(55, 15);
            this.lblMaterias.TabIndex = 6;
            this.lblMaterias.Text = "Materias";
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Items.AddRange(new object[] {
            "Programación I",
            "Laboratorio de Computación I",
            "Sistema de procesamiento de datos",
            "Inglés I",
            "Matemática",
            "Programación II",
            "Laboratorio de Computación II",
            "Inglés II",
            "Metodología de la investigación",
            "Arquitectura y sistemas operativos",
            "Estadística"});
            this.cmbMaterias.Location = new System.Drawing.Point(22, 165);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(210, 23);
            this.cmbMaterias.TabIndex = 7;
            this.cmbMaterias.Text = "Seleccione su materia preferida";
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbMaterias_SelectedIndexChanged_1);
            // 
            // FrmI01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 273);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBDos);
            this.Controls.Add(this.txtBUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmI01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmI01_FormClosing);
            this.Load += new System.EventHandler(this.FrmI01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBUno;
        private System.Windows.Forms.TextBox txtBDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.ComboBox cmbMaterias;
    }
}
