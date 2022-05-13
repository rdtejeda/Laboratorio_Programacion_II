namespace FormPrincipal
{
    partial class FrmAtención
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
            this.btnAtender = new System.Windows.Forms.Button();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.rtbInfoMedico = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(576, 59);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(115, 60);
            this.btnAtender.TabIndex = 2;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 15;
            this.lstMedicos.Location = new System.Drawing.Point(26, 59);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(207, 139);
            this.lstMedicos.TabIndex = 3;
            this.lstMedicos.SelectedIndexChanged += new System.EventHandler(this.lstMedicos_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(576, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 57);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(262, 59);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(250, 139);
            this.lstPacientes.TabIndex = 5;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(26, 21);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(95, 15);
            this.lblMedicos.TabIndex = 6;
            this.lblMedicos.Text = "Personal médico";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(262, 21);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(52, 15);
            this.lblPacientes.TabIndex = 7;
            this.lblPacientes.Text = "Paciente";
            // 
            // rtbInfoMedico
            // 
            this.rtbInfoMedico.Location = new System.Drawing.Point(26, 221);
            this.rtbInfoMedico.Name = "rtbInfoMedico";
            this.rtbInfoMedico.Size = new System.Drawing.Size(486, 144);
            this.rtbInfoMedico.TabIndex = 8;
            this.rtbInfoMedico.Text = "";
            // 
            // FrmAtención
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 388);
            this.Controls.Add(this.rtbInfoMedico);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.btnAtender);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAtención";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tejeda Roberto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RichTextBox rtbInfoMedico;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblMedicos;
    }
}
