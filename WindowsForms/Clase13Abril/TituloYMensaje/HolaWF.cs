using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TituloYMensaje
{
    public partial class HolaWF : Form
    {
        
        public HolaWF(string saludo, string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = saludo;
            lblSaludo.Text = mensaje;
        }
        
        private void HolaWF_Load(object sender, EventArgs e)
        {

        }
    }
}
