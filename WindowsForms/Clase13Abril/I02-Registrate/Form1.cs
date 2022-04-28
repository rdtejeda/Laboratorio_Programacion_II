using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I02_Registrate
{
    public partial class frmRegistrate : Form
    {
        public frmRegistrate()
        {
            InitializeComponent();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string genero="No selected";
            int posicionArrayCurso = 0;
            string[] curso = new string[3];
            if (true)
            {
               if(chekBCmas.Checked)
                {
                    curso[posicionArrayCurso] = "C++";
                    posicionArrayCurso++;
                }
                if(chekBCSharp.Checked)
                {
                    curso[posicionArrayCurso] = "C#";
                    posicionArrayCurso++;
                }
               if(chekBJS.Checked)
                {
                    curso[posicionArrayCurso] = "JavaScript";
                    posicionArrayCurso++;
                }

                if(rButtNB.Checked)
                {
                    genero = "No Binario";
                }
                if (rButtFem.Checked)
                {
                    genero = "Femenino";
                }
                if (rButtMas.Checked)
                {
                    genero = "Masculino";
                }

                Ingresante nuevoIngresante = new Ingresante(curso ,txtBDirec.Text,numUDEdad.Text,genero, txtBNombre.Text, listBPais.Text);
                MessageBox.Show(nuevoIngresante.Mostra());                                          
            }
           
            

        }

        private void frmRegistrate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar?", "Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /*
        private bool Validar()
        {
            bool validado = true;
            StringBuilder error = new StringBuilder();
            error.AppendLine("Completar los campos:");
            if (string.IsNullOrEmpty(txtBNombre.Text))
            {
                validado = false;
                error.AppendLine("Nombre");
            }
            if (string.IsNullOrEmpty(txtBDirec.Text))
            {
                validado = false;
                error.AppendLine("Dirección");
            }            
            if(numUDEdad.DecimalPlaces<=18)
            {
                validado = false;
                error.AppendLine("Edad");

            }
            if(true)
            {

            }

            if (string.IsNullOrWhiteSpace((string?)cmbMaterias.SelectedItem))
            {
                validado = false;
                error.AppendLine("Materia Preferida");
            }
            if (!validado)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validado;
        }
        */

        private void numUDEdad_Validated(object sender, EventArgs e)
        {
            
        }

        private void grpBGenero_Enter(object sender, EventArgs e)
        {

        }
    }
}
