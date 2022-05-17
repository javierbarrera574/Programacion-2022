using System;
using System.Windows.Forms;
using System.Globalization;

namespace Multiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void btMultiplicar_Click(object sender, EventArgs e)
        {

            double operador1;

            double operador2;

            double resultado;

            string mostrar;

         

            operador1 = Convert.ToDouble(txtOperador1.Text, CultureInfo.InvariantCulture);

            operador2 = Convert.ToDouble(txtOperador2.Text, CultureInfo.InvariantCulture);


            resultado = operador1 * operador2;

            mostrar = String.Format("{0:F2}",resultado, CultureInfo.InvariantCulture);

            txtResultado.Text = mostrar;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtOperador1.Text = null;

            txtOperador2.Text = null;

            txtResultado.Text = null;




        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }

}





/*
 * La cadena de formnato {"0:F2"} lo que hace es:
 * 
 * el cero es el primer argumento, la letra F es que
 *  
 * vamos a imprimir un tipo de dato doble y el numero dos
 * 
 * la cantidad de decimales que va a tener nuestra operacion 
 * 
 * IFormatProvider Interfaz:
 * 
 * Proporciona un mecanismo para recuperar un objeto que controle el formato.
 * 
 */



