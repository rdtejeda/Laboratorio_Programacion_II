namespace Login
{
    partial class FrmMenu
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.rchTrBAlumnos = new System.Windows.Forms.RichTextBox();
            this.btnMostarAlumnos = new System.Windows.Forms.Button();
            this.lblNulos = new System.Windows.Forms.Label();
            this.lblTituloNull = new System.Windows.Forms.Label();
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.btnMostrarProfesores = new System.Windows.Forms.Button();
            this.lblEleccion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(0, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(100, 23);
            this.lblMensaje.TabIndex = 2;
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajes.Location = new System.Drawing.Point(277, 12);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(102, 21);
            this.lblMensajes.TabIndex = 1;
            this.lblMensajes.Text = "Bienvenido ";
            // 
            // rchTrBAlumnos
            // 
            this.rchTrBAlumnos.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rchTrBAlumnos.Location = new System.Drawing.Point(12, 12);
            this.rchTrBAlumnos.Name = "rchTrBAlumnos";
            this.rchTrBAlumnos.Size = new System.Drawing.Size(239, 364);
            this.rchTrBAlumnos.TabIndex = 3;
            this.rchTrBAlumnos.Text = "Alumnos";
            // 
            // btnMostarAlumnos
            // 
            this.btnMostarAlumnos.Location = new System.Drawing.Point(277, 117);
            this.btnMostarAlumnos.Name = "btnMostarAlumnos";
            this.btnMostarAlumnos.Size = new System.Drawing.Size(206, 44);
            this.btnMostarAlumnos.TabIndex = 4;
            this.btnMostarAlumnos.Text = "Mostrar Alumnos";
            this.btnMostarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostarAlumnos.Click += new System.EventHandler(this.btnMostarAlumnos_Click);
            // 
            // lblNulos
            // 
            this.lblNulos.AutoSize = true;
            this.lblNulos.Location = new System.Drawing.Point(277, 337);
            this.lblNulos.Name = "lblNulos";
            this.lblNulos.Size = new System.Drawing.Size(23, 28);
            this.lblNulos.TabIndex = 5;
            this.lblNulos.Text = "0";
            // 
            // lblTituloNull
            // 
            this.lblTituloNull.AutoSize = true;
            this.lblTituloNull.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloNull.Location = new System.Drawing.Point(277, 315);
            this.lblTituloNull.Name = "lblTituloNull";
            this.lblTituloNull.Size = new System.Drawing.Size(74, 15);
            this.lblTituloNull.TabIndex = 6;
            this.lblTituloNull.Text = "Cargas Nulas";
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.Location = new System.Drawing.Point(277, 254);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(206, 42);
            this.btnMostrarMaterias.TabIndex = 7;
            this.btnMostrarMaterias.Text = "Mostrar Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = true;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // btnMostrarProfesores
            // 
            this.btnMostrarProfesores.Location = new System.Drawing.Point(277, 184);
            this.btnMostrarProfesores.Name = "btnMostrarProfesores";
            this.btnMostrarProfesores.Size = new System.Drawing.Size(206, 44);
            this.btnMostrarProfesores.TabIndex = 8;
            this.btnMostrarProfesores.Text = "Mostrar Profesores";
            this.btnMostrarProfesores.UseVisualStyleBackColor = true;
            this.btnMostrarProfesores.Click += new System.EventHandler(this.btnMostrarProfesores_Click);
            // 
            // lblEleccion
            // 
            this.lblEleccion.AutoSize = true;
            this.lblEleccion.Location = new System.Drawing.Point(277, 75);
            this.lblEleccion.Name = "lblEleccion";
            this.lblEleccion.Size = new System.Drawing.Size(151, 28);
            this.lblEleccion.TabIndex = 9;
            this.lblEleccion.Text = "Elije la opción :";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(366, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 41);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEleccion);
            this.Controls.Add(this.btnMostrarProfesores);
            this.Controls.Add(this.btnMostrarMaterias);
            this.Controls.Add(this.lblTituloNull);
            this.Controls.Add(this.lblNulos);
            this.Controls.Add(this.btnMostarAlumnos);
            this.Controls.Add(this.rchTrBAlumnos);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.lblMensaje);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.RichTextBox rchTrBAlumnos;
        private System.Windows.Forms.Button btnMostarAlumnos;
        private System.Windows.Forms.Label lblNulos;
        private System.Windows.Forms.Label lblTituloNull;
        private System.Windows.Forms.Button btnMostrarMaterias;
        private System.Windows.Forms.Button btnMostrarProfesores;
        private System.Windows.Forms.Label lblEleccion;
        private System.Windows.Forms.Button btnSalir;
    }
}