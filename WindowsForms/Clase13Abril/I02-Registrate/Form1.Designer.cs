namespace I02_Registrate
{
    partial class frmRegistrate
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
            this.grpBNomDirEdad = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.numUDEdad = new System.Windows.Forms.NumericUpDown();
            this.txtBDirec = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.grpBGenero = new System.Windows.Forms.GroupBox();
            this.rButtMas = new System.Windows.Forms.RadioButton();
            this.rButtFem = new System.Windows.Forms.RadioButton();
            this.rButtNB = new System.Windows.Forms.RadioButton();
            this.grpBoxCurso = new System.Windows.Forms.GroupBox();
            this.chekBJS = new System.Windows.Forms.CheckBox();
            this.chekBCmas = new System.Windows.Forms.CheckBox();
            this.chekBCSharp = new System.Windows.Forms.CheckBox();
            this.listBPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpBNomDirEdad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdad)).BeginInit();
            this.grpBGenero.SuspendLayout();
            this.grpBoxCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBNomDirEdad
            // 
            this.grpBNomDirEdad.Controls.Add(this.lblEdad);
            this.grpBNomDirEdad.Controls.Add(this.lblDireccion);
            this.grpBNomDirEdad.Controls.Add(this.lblNombre);
            this.grpBNomDirEdad.Controls.Add(this.numUDEdad);
            this.grpBNomDirEdad.Controls.Add(this.txtBDirec);
            this.grpBNomDirEdad.Controls.Add(this.txtBNombre);
            this.grpBNomDirEdad.Location = new System.Drawing.Point(38, 28);
            this.grpBNomDirEdad.Name = "grpBNomDirEdad";
            this.grpBNomDirEdad.Size = new System.Drawing.Size(173, 205);
            this.grpBNomDirEdad.TabIndex = 0;
            this.grpBNomDirEdad.TabStop = false;
            this.grpBNomDirEdad.Text = "Nombre -Dirección-Edad";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(25, 147);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 89);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // numUDEdad
            // 
            this.numUDEdad.Location = new System.Drawing.Point(25, 165);
            this.numUDEdad.Name = "numUDEdad";
            this.numUDEdad.Size = new System.Drawing.Size(70, 23);
            this.numUDEdad.TabIndex = 2;
            this.numUDEdad.Validated += new System.EventHandler(this.numUDEdad_Validated);
            // 
            // txtBDirec
            // 
            this.txtBDirec.Location = new System.Drawing.Point(25, 107);
            this.txtBDirec.Name = "txtBDirec";
            this.txtBDirec.Size = new System.Drawing.Size(100, 23);
            this.txtBDirec.TabIndex = 1;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(25, 47);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(100, 23);
            this.txtBNombre.TabIndex = 0;
            // 
            // grpBGenero
            // 
            this.grpBGenero.Controls.Add(this.rButtMas);
            this.grpBGenero.Controls.Add(this.rButtFem);
            this.grpBGenero.Controls.Add(this.rButtNB);
            this.grpBGenero.Location = new System.Drawing.Point(217, 37);
            this.grpBGenero.Name = "grpBGenero";
            this.grpBGenero.Size = new System.Drawing.Size(99, 102);
            this.grpBGenero.TabIndex = 1;
            this.grpBGenero.TabStop = false;
            this.grpBGenero.Text = "Genero";
            this.grpBGenero.Enter += new System.EventHandler(this.grpBGenero_Enter);
            // 
            // rButtMas
            // 
            this.rButtMas.AutoSize = true;
            this.rButtMas.Location = new System.Drawing.Point(11, 71);
            this.rButtMas.Name = "rButtMas";
            this.rButtMas.Size = new System.Drawing.Size(80, 19);
            this.rButtMas.TabIndex = 2;
            this.rButtMas.TabStop = true;
            this.rButtMas.Text = "Masculino";
            this.rButtMas.UseVisualStyleBackColor = true;
            // 
            // rButtFem
            // 
            this.rButtFem.AutoSize = true;
            this.rButtFem.Location = new System.Drawing.Point(11, 47);
            this.rButtFem.Name = "rButtFem";
            this.rButtFem.Size = new System.Drawing.Size(78, 19);
            this.rButtFem.TabIndex = 1;
            this.rButtFem.TabStop = true;
            this.rButtFem.Text = "Femenino";
            this.rButtFem.UseVisualStyleBackColor = true;
            // 
            // rButtNB
            // 
            this.rButtNB.AutoSize = true;
            this.rButtNB.Location = new System.Drawing.Point(11, 22);
            this.rButtNB.Name = "rButtNB";
            this.rButtNB.Size = new System.Drawing.Size(81, 19);
            this.rButtNB.TabIndex = 0;
            this.rButtNB.TabStop = true;
            this.rButtNB.Text = "No Binario";
            this.rButtNB.UseVisualStyleBackColor = true;
            // 
            // grpBoxCurso
            // 
            this.grpBoxCurso.Controls.Add(this.chekBJS);
            this.grpBoxCurso.Controls.Add(this.chekBCmas);
            this.grpBoxCurso.Controls.Add(this.chekBCSharp);
            this.grpBoxCurso.Location = new System.Drawing.Point(217, 145);
            this.grpBoxCurso.Name = "grpBoxCurso";
            this.grpBoxCurso.Size = new System.Drawing.Size(99, 96);
            this.grpBoxCurso.TabIndex = 2;
            this.grpBoxCurso.TabStop = false;
            this.grpBoxCurso.Text = "Curso";
            // 
            // chekBJS
            // 
            this.chekBJS.AutoSize = true;
            this.chekBJS.Location = new System.Drawing.Point(7, 66);
            this.chekBJS.Name = "chekBJS";
            this.chekBJS.Size = new System.Drawing.Size(78, 19);
            this.chekBJS.TabIndex = 2;
            this.chekBJS.Text = "JavaScript";
            this.chekBJS.UseVisualStyleBackColor = true;
            // 
            // chekBCmas
            // 
            this.chekBCmas.AutoSize = true;
            this.chekBCmas.Location = new System.Drawing.Point(7, 41);
            this.chekBCmas.Name = "chekBCmas";
            this.chekBCmas.Size = new System.Drawing.Size(50, 19);
            this.chekBCmas.TabIndex = 1;
            this.chekBCmas.Text = "C++";
            this.chekBCmas.UseVisualStyleBackColor = true;
            // 
            // chekBCSharp
            // 
            this.chekBCSharp.AutoSize = true;
            this.chekBCSharp.Location = new System.Drawing.Point(6, 16);
            this.chekBCSharp.Name = "chekBCSharp";
            this.chekBCSharp.Size = new System.Drawing.Size(41, 19);
            this.chekBCSharp.TabIndex = 0;
            this.chekBCSharp.Text = "C#";
            this.chekBCSharp.UseVisualStyleBackColor = true;
            // 
            // listBPais
            // 
            this.listBPais.FormattingEnabled = true;
            this.listBPais.ItemHeight = 15;
            this.listBPais.Items.AddRange(new object[] {
            "Argentina",
            "Uruguay",
            "Chile"});
            this.listBPais.Location = new System.Drawing.Point(38, 265);
            this.listBPais.Name = "listBPais";
            this.listBPais.Size = new System.Drawing.Size(95, 64);
            this.listBPais.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(38, 247);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(192, 265);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(117, 41);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmRegistrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 334);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.listBPais);
            this.Controls.Add(this.grpBoxCurso);
            this.Controls.Add(this.grpBGenero);
            this.Controls.Add(this.grpBNomDirEdad);
            this.Name = "frmRegistrate";
            this.Text = "Registrate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistrate_FormClosing);
            this.grpBNomDirEdad.ResumeLayout(false);
            this.grpBNomDirEdad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdad)).EndInit();
            this.grpBGenero.ResumeLayout(false);
            this.grpBGenero.PerformLayout();
            this.grpBoxCurso.ResumeLayout(false);
            this.grpBoxCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBNomDirEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown numUDEdad;
        private System.Windows.Forms.TextBox txtBDirec;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.GroupBox grpBGenero;
        private System.Windows.Forms.RadioButton rButtMas;
        private System.Windows.Forms.RadioButton rButtFem;
        private System.Windows.Forms.RadioButton rButtNB;
        private System.Windows.Forms.GroupBox grpBoxCurso;
        private System.Windows.Forms.CheckBox chekBJS;
        private System.Windows.Forms.CheckBox chekBCmas;
        private System.Windows.Forms.CheckBox chekBCSharp;
        private System.Windows.Forms.ListBox listBPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
