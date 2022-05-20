namespace VisorDeImagenesyEnlaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { // Carga la imagen dentro del cuadro picture box.
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // Muestra el nombre del archivo en el titulo de forma

            this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName
            + ")");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        //usando el sistema de diagnostico, hago lo siguiente pasando parametros

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("Calc");
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = false;
            System.Diagnostics.Process.Start("Google Chrome",
            "http://www.sierrascalientes.com");
        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = false;
            System.Diagnostics.Process.Start("C:/");


            if (linkLabel3.LinkVisited!=false)
            {


            }

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;

            System.Diagnostics.Process.Start("http://www.youtube.com");
        }
    }
}




/*
 * CONSTA DE DOS SECCIONES
 * 
 * LA PRIMERA ABRE UN VISOR DE IMAGENES
 * 
 * LA SEGUNDA ABRE UNA CALCULADORA, UNA PAGINA DE UNA UNIVERSIDAD, Y POR ULTIMO EXPLORAR DE WINDOWS
 * 
 * Los controles necesarios para llevar a cabo el proyecto son:
1 Caja de Imagen (pictureBox)
1 Caja de dialogo para abrir un archivo (openFileDialog)
2 Botones (Button)
3 Etiquetas de Enlace (linkLabel)
 * 
 * 
 * propiedad de linklabel es la de LinkVisited, que cambia de color
 * 
 * cada vez que alguien visita nuestro link
 */

