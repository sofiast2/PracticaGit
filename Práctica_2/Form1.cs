using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0; // Inicializamos el coste en 0 para evitar posibles errores


            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // Telegrama Urgente?
          
        {
            // Asumimos que tienes 2 RadioButtons: radioBtn1 (Ordinario) y radioBtn2 (Urgente)
            if (radioBtn2.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                tipoTelegrama = 'o';
            }

                // Ejemplo: Actualizar un Label con el tipo de telegrama
                numPalabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
             
        }



            // Si el telegrama es ordinario
            if (tipoTelegrama != 'u')
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    coste = 3 + 0.5 * (numPalabras - 10); // Modificado para sumar al coste base
                }
            }
            else
            {
                // Si el telegrama es urgente
                if (numPalabras <= 10)
                {
                    coste = 6;
                }
                else
                {
                    coste = 6 + 0.75 * (numPalabras - 10);
                }
            }

            txtPrecio.Text = coste.ToString("0.00") + " euros";
        }
    }
}