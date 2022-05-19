namespace Login
{
    partial class FrmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPaswword = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPasw = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(25, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 46);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Logeate";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(25, 27);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.PlaceholderText = "Ingrese Usuario";
            this.tbxUser.Size = new System.Drawing.Size(100, 23);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.Text = "123123";
            // 
            // tbxPaswword
            // 
            this.tbxPaswword.Location = new System.Drawing.Point(25, 71);
            this.tbxPaswword.Name = "tbxPaswword";
            this.tbxPaswword.PasswordChar = '*';
            this.tbxPaswword.PlaceholderText = "Ingrese Pasword";
            this.tbxPaswword.Size = new System.Drawing.Size(100, 23);
            this.tbxPaswword.TabIndex = 2;
            this.tbxPaswword.Text = "lucas123";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 15);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario/Id";
            // 
            // lblPasw
            // 
            this.lblPasw.AutoSize = true;
            this.lblPasw.Location = new System.Drawing.Point(25, 53);
            this.lblPasw.Name = "lblPasw";
            this.lblPasw.Size = new System.Drawing.Size(47, 15);
            this.lblPasw.TabIndex = 4;
            this.lblPasw.Text = "Paword";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(25, 184);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 264);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPasw);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbxPaswword);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPaswword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPasw;
        private System.Windows.Forms.Button btnSalir;
    }
}
