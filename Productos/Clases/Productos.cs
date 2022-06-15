using Entidades;
//using System.DataTable;
namespace Clases
{
    

    public partial class Productos : Form
    {
        

        Producto NuevoProducto = new Producto();


        DataTable anda = new DataTable();
    
        public Productos()
        {
            InitializeComponent();


            //dgProductos.DataSource = dt;

        }

          

      

        

        private void btCargar_Click(object sender, EventArgs e)
        {
            //Voy a especificar el error de excepcion que me arroje el compilador

            try
            {
                //Estoy invocando el constructor al que le paso metodos
                NuevoProducto = new Producto(int.Parse(txtcodigo.Text), txtdescripcion.Text);

                lblCodigoMovimiento.Text = NuevoProducto.CodigoAInvocar.ToString();

                lblDescripcionMovimiento.Text = NuevoProducto.descriptivo;

                lblStockMovimiento.Text = " Hay " + NuevoProducto.stockpedir.ToString() + " unidades " + " en el deposito ";

                

            


                txtCantidadMovimiento.Focus();

                MessageBox.Show("Producto instanciado");



            }
            catch (Exception)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
           
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = e.RowIndex;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}