using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I01_HolaWindowsForms;
using TituloYMensaje;

namespace I01_HolaWindowsForms
{
    public partial class FrmI01 : Form
    {
        public FrmI01()
        {
            InitializeComponent();
        }

        private void FrmI01_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar?", "Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            string titulo = $" Soy {txtBUno.Text} {txtBDos.Text} y mi materia preferida es {cmbMaterias.SelectedItem}";
            string saludo = "¡Hola, Windows Forms!";
            if(Validar())
            {
                HolaWF hwf = new HolaWF(titulo,saludo);            
                hwf.ShowDialog();
            }            
        }

        private bool Validar()
        {
            bool validado = true;
            StringBuilder error = new StringBuilder();
            error.AppendLine("Completar los campos:");
            if(string.IsNullOrEmpty(txtBDos.Text))
            {
                validado = false;
                error.AppendLine("Apellido");
            }
            if(string.IsNullOrEmpty(txtBUno.Text))
            {
                validado = false;
                error.AppendLine("Nombre");
            }
            if(string.IsNullOrWhiteSpace((string?)cmbMaterias.SelectedItem))
            {
                validado = false;
                error.AppendLine("Materia Preferida");
            }
            if(!validado)
            {
                MessageBox.Show(error.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }          
            return validado;
        }
        private void FrmI01_Load(object sender, EventArgs e)
        {

        }

        private void txtBUno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBDos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaterias_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
