using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEntidades;

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ///PUEDO METR IF TRY CATCH ELSE TRY CATCH
            try
            {
                if (tBxKilometros.Text == "" || tBxLitros.Text == ""  )
                {
                    throw new ParametroVacioException("Bebe completar ambos campos");
                }
                this.richTextBox1.Text = $"km/hs. {Calcular.Calculo(int.Parse(this.tBxKilometros.Text),int.Parse(this.tBxLitros.Text))}";
            }
            catch (ParametroVacioException ex) //Exceptio is generic excepcion
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("el formato de datos noe es el correcto");// ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               // MessageBox.Show("Pasé");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
