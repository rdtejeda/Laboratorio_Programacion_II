using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase13Abril
{
    public partial class FrmVista : Form
    {
        public FrmVista()
        {
            InitializeComponent();
        }

        private void FrmVista_FormClosing(object sender, FormClosingEventArgs e)
        {
           // 
           if(MessageBox.Show("Cerrar?","Desea Salir?",MessageBoxButtons.YesNo,MessageBoxIcon.Hand)==DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void FrmVista_Load(object sender, EventArgs e)
        {

        }
    }
}
