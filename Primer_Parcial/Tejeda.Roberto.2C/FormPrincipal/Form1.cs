using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FormPrincipal
{
    public partial class FrmAtención : Form
    {
        PersonalMedico unPersonalMedico = null;
        public FrmAtención()
        {
            InitializeComponent();  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnAtender_Click(object sender, EventArgs e)
        {
            Consulta laConsulta;
            Paciente unPaciente;
            if (lstMedicos.SelectedItem is not null && lstPacientes.SelectedItem is not null )
            {
                unPersonalMedico = lstMedicos.SelectedItem as PersonalMedico;
                unPaciente = lstPacientes.SelectedItem as Paciente;
                if (unPaciente is not null && unPersonalMedico is not null)
                {
                    Random random = new Random();
                    unPaciente.PDiagnostico = (Paciente.Diagnostico)random.Next(0, 3);
                    laConsulta = unPersonalMedico + unPaciente;
                    rtbInfoMedico.Text = Persona.FichaPersonal(((Persona)unPersonalMedico));
                    MessageBox.Show(laConsulta.ToString(), "Atencion Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lstPacientes.Items.Remove(lstPacientes.SelectedItem);
                lstMedicos.Items.Remove(lstMedicos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstMedicos.SelectedItem is not null)
            {
                unPersonalMedico = lstMedicos.SelectedItem as PersonalMedico;
                rtbInfoMedico.Text = Persona.FichaPersonal(((Persona)unPersonalMedico));
            }
        }
    }
}