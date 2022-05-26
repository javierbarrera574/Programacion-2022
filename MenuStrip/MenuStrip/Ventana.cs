using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo2.jpg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
           




        }
    }
}
