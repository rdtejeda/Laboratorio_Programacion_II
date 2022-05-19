using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUniversidad;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.tbxUser.Text != string.Empty && this.tbxPaswword.Text != string.Empty)
            {
                try
                {
                    if (Universidad.Loguear(int.Parse(this.tbxUser.Text), this.tbxPaswword.Text))
                    {
                        FrmMenu menu = new FrmMenu();
                        menu.ActualizarMensaje(this.tbxUser.Text);
                        //MessageBox.Show("El usuario se ha logeado");
                        menu.Show();
                        this.Hide();
                    }
                }
                catch(UnauthorizedAccessException ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message}");
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show($"Usuario no se ha logeado, {ex.Message} + {ex.ToString()} + {ex.Data}");
                }
                
            }else
            {
                    MessageBox.Show("DEBE COMPLETAR AMBOS CAMPOS PARA SER logeado");
                    this.tbxUser.Text = string.Empty;
                    this.tbxPaswword.Text = string.Empty;
            }
            /*
            if(this.tbxUser.Text=="Roberto" && this.tbxPaswword.Text=="1234")
            {
                //FrmMenu menu = new FrmMenu(this.tbxUser.Text);
                FrmMenu menu = new FrmMenu();
                menu.ActualizarMensaje(this.tbxUser.Text);
                menu.Show();
                this.Hide();
               // MessageBox.Show("El usuario se ha logeado");
            }
            else
            {
                MessageBox.Show("Usuario no se ha logeado");
                this.tbxUser.Text = string.Empty;
                this.tbxPaswword.Text = string.Empty;   
            }
            */
        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar?", "Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
