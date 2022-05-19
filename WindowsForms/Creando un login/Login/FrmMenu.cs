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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        /*
        public FrmMenu(string nombreusuario):this()
        {
            this.lblMensajes.Text = this.lblMensajes.Text+nombreusuario;
        }
        */
        public void ActualizarMensaje(string nombre)
        {
            this.lblMensajes.Text = this.lblMensajes.Text + nombre;
        }
        private void btnMostarAlumnos_Click(object sender, EventArgs e)
        {
            int nulos = 0;
            int buenos = 0;
            StringBuilder sb = new StringBuilder();
            this.rchTrBAlumnos.Clear();
            this.lblNulos.Text = "0";
            foreach (Alumno alumno in Universidad.Alumnos)
            {
                try
                {
                    sb.AppendLine(alumno.ToString());
                    //this.rchTrBAlumnos.Text += alumno.ToString()+"\n";
                    //this.rchTrBAlumnos.Text = sb.ToString();
                    buenos++;
                }
                catch (Exception ex)
                {
                    nulos++;
                    //MessageBox.Show($"Mostrar Alumno {ex.Message}");
                }
            }
            this.lblNulos.Text = nulos.ToString();
            this.rchTrBAlumnos.Text =$"Se han cargado {buenos.ToString()} alumos \n"+"ALUMNOS\n"+sb.ToString();
            /*
             catch (Exception ex)
             {
                 MessageBox.Show($"Usuario no se ha logeado, {ex.Message} + {ex.ToString()} + {ex.Data}");
                 throw;
             }
            */
        }
        private void btnMostrarProfesores_Click(object sender, EventArgs e)
        {
            int nulos = 0;
            int buenos = 0;
            StringBuilder sb = new StringBuilder();
            this.rchTrBAlumnos.Clear();
            this.lblNulos.Text = "0";
            foreach (Profesor profesor in Universidad.Profesores)
            {
                try
                {
                    sb.AppendLine(profesor.ToString());
                    buenos++;
                }
                catch (Exception ex)
                {
                    nulos++;
                }
            }
            this.lblNulos.Text = nulos.ToString();
            this.rchTrBAlumnos.Text = $"Se han cargado {buenos.ToString()} profesores \n" + "PROFESORES\n" + sb.ToString();
        }

        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            int nulos = 0;
            int buenos = 0;
            StringBuilder sb = new StringBuilder();
            this.rchTrBAlumnos.Clear();
            this.lblNulos.Text = "0";
            foreach (Materia materia in Universidad.Materias)
            {
                try
                {
                    sb.AppendLine(materia.ToString());
                    buenos++;
                }
                catch (Exception ex)
                {
                    nulos++;
                }
            }
            this.lblNulos.Text = nulos.ToString();
            this.rchTrBAlumnos.Text = $"Se han cargado {buenos.ToString()} materias \n" + "MATERIAS\n" + sb.ToString();
        }
        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
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
