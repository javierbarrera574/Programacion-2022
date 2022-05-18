using System;
using System.Windows.Forms;

namespace MesasageBox
{
    public partial class Form1 : Form
    {

        //Creo la variable privada para usarla en el metodo, y controlar las acciones del típo de boton


        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;

        //creo esta variable privada para controlar las acciones del tipo de icono

        private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;
        public Form1()
        {


            InitializeComponent();



        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables de cuadro de dialogo

            DialogResult result =
            MessageBox.Show("Mensaje a desplegar",
                            "Título de la Ventana",


               tipoDeBoton,
               tipoDeIcono);

            switch (result)
            {
                case DialogResult.OK: label2.Text = "Seleccionó OK."; break;
                case DialogResult.Cancel: label2.Text = "Seleccionó Cancelar."; break;
                case DialogResult.Yes: label2.Text = "Seleccionó SI."; break;
                case DialogResult.No: label2.Text = "Seleccionó NO."; break;
                case DialogResult.Ignore: label2.Text = "Seleccionó Ignorar."; break;
                case DialogResult.Abort: label2.Text = "Seleccionó Abortar."; break;
                case DialogResult.Retry: label2.Text = "Seleccionó Reintentar."; break;
            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        //Creo el metodo para cambiar los valores de los botones de radio
        //se cargaron todas las referencias donde llamamos al metodo, aca y en el metodo del icono
        private void tipoDeBoton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton1)
                tipoDeBoton = MessageBoxButtons.OK;
            else if (sender == radioButton2)
                tipoDeBoton = MessageBoxButtons.OKCancel;
            else if (sender == radioButton3)
                tipoDeBoton = MessageBoxButtons.YesNo;
            else if (sender == radioButton4)
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            else if (sender == radioButton5)
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            else
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
            //investigar bien todo este codigo de arriba

        }

        //creo el metodo para cambiar los valores del tipo de icono

        private void tipoDeIcono_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton7) //icono de error de visualización
                tipoDeIcono = MessageBoxIcon.Information;
            else if (sender == radioButton8)
                tipoDeIcono = MessageBoxIcon.Exclamation;
            else if (sender == radioButton9)
                tipoDeIcono = MessageBoxIcon.Question;
            else //solo queda una opción: mostrar el signo de interrogación
                tipoDeIcono = MessageBoxIcon.Error;

            //investigar bien este codigo de arriba
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = null;
        }
    }
}



/*
 * LA CAJA DE MENSAJES(messagebox), ES UN METODO POLIFORMO
 * 
 * YA QUE TIENE VEINTEUN (21) FORMAS DIFERENTES PARA LLARARLO(INVOCARLO. 
 * 
 * GroupBox(caja de agrupamiento de elementos)--> ES UNA COLECCION
 * 
 * 
 * LOS RadioButton(BOTONES DE RADIO O DE OPCION), NOS PERMITE SELECCIONAR
 * 
 * UNA OPCION DE UNO O MAS COLECCIONES
 * 
 * 
 * PARA HACER QUE FUNCIONE TENGO QUE PROGRAMAR CADA EVENTO DE LOS BOTONES DE RADIO
 * 
 * Radiobutton
 * 
 * Grupos(GroupBox)
 * 
 * Checked
 * 
 * 
 * 
 * En el código anterior se investiga cual de los radioButtons (mediante sender) cambió su
estatus de desactivado a activado y se pone la variable tipoDeBoton con uno de los 6 posibles
valores que tiene la enumeración MessageBoxButtons.


Como en el primer método, se investiga cual de los radioButtons (mediante sender) cambió su
estatus de desactivado a activado y se pone la variable tipoDeIcono con uno de los cuatro
posibles valores que tiene la enumeración MessageBoxIcon.
 */