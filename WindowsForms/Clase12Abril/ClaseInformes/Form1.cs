using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseInformes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevoFormulario_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hola Mundo");
           Form2 miform2 = new Form2();
           // miform2.ShowDialog(); //puedouno solo
            miform2.Show(); //puedo varios
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //e.Cancel = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
