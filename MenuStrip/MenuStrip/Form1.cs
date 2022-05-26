using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }


        private void Abrir_Click(object sender, EventArgs e)
        {
            Ventana abrir = new Ventana();

            abrir.ShowDialog();
        }


        

        private void Cargar_Menu()
        {

            int Id = 1;

            foreach (string items in AgregarElementos())
            {
                ToolStripMenuItem item = new  ToolStripMenuItem(items);

                item.Tag = Id;

                Id++;

                toolStripMenuItem1.DropDownItems.Add(item);


                item.Click  += new EventHandler(Item_Click);


               
            }
        
        }

        private void Item_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem item = sender as ToolStripMenuItem;
           
            MessageBox.Show("Este es el SubMenu "  +  item.Tag);

        }

        private List<String> AgregarElementos()
        {
            List<String> items_Menu = new List<String>();

            items_Menu.Add("SubMenu 1");
            items_Menu.Add("SubMenu 2");
            items_Menu.Add("SubMenu 3");
            items_Menu.Add("SubMenu 4");
           
            return items_Menu;



        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


     
        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            txtContenido.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar_Menu();
        }

       

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            //OBTENEMOS LISTA DE ARCHIVOS CON SU RUTA CORRESPONDIENTE

            string[] Archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //HACEMOS UN TYPECAST

            string leer = "";

            //Image[] Archivos2 = (Image[])e.Data.GetData(DataFormats.FileDrop, false);


            lblGuardar.Text = Archivos[1];

            //LA POSICION CERO([0]) ES EL NOMBRE Y RUTA DEL PRIMER ARCHIVO QUE MANDEMOS
            //Y ASI SUCESIVAMENTE

            StreamReader Lectura = File.OpenText(Archivos[1]);

            //ImageListStreamer lectura = File.OpenRead(Archivos2[0]).Read());

            while ((leer=Lectura.ReadLine()) != null)
            {

                txtContenido.Text += leer + Environment.NewLine;
            }

          

            Lectura.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtContenido.Text = null;

        }
    }
}