using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnificarColas(Cola[] colas, Cola cola)
        {
            for (int i = 0; i < colas.Length; i++)
            {
                while (colas[i].primero != null)
                {
                    cola.encolar(colas[i].desencolar());
                }
            }
        }
        private void btnUnify_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int numeroColas = int.Parse(txtNumColas.Text);
            int numeroElementos = int.Parse(txtNumElementos.Text);

            if  (numeroColas != 0)
            {
                Cola[] colas = new Cola[numeroColas];
                Cola colaFinal = new Cola();

                for (int i = 0; i < numeroColas; i++)
                {
                    if (numeroElementos != 0)
                    {
                        colas[i] = new Cola();
                        for (int j = 0; j < numeroElementos; j++)
                        {
                            if (numero != 0)
                            {
                                colas[i].encolar(numero);
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                UnificarColas(colas, colaFinal);

                colaFinal.mostrar(txtColaFinal);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
 }
