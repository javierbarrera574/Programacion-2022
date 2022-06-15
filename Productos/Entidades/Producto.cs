using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {


        #region Atributos

        //Estamos encapsulando los objetos

        private int Codigo;

        private string Descripcion;

        private int Stock;
        #endregion Atributos


        //Utilizamos las propiedades para acceder a los Atributos

        #region Propiedades

        public int CodigoAInvocar
        {
            set { Codigo = value; } //pido

            get { return Codigo;} //devuelvo
        }
        

        public string descriptivo
        {
            set { Descripcion = value; }

            get { return Descripcion;}
        }

        public int stockpedir
        {
            //queremos que el stock no se modifique desde afuera
            get { return Stock; }
            
        }

        #endregion Propiedades


        #region Constructores

        //Ingreso los constructores(LLEVAN EL MISMO NOMBRE DE LA CLASE)
        //Cada vez que cargamos un producto, deberiamos instanciar un objeto producto
        public Producto() //Es reemplazado por el constructor que recibe argumentos
        {

        }

       




        //public class perro
        //{

        //}





        public Producto(int cod, string descrip)
        {
            //cod se asigna al atributo Codigo desde el constructor
            //descrip se asigna al atributo Descripcion desde el constructor

            Codigo = cod;

            Descripcion = descrip;

            //Cargo el stock por defecto en nulo
          

            Stock = 0; //cuando se crea un nuevo producto, se instancia en cero

        }
        #endregion Constructores

        #region Metodos
        public void IngresoProducto(int cantidad)
        {

            //Incremento el stock segun la cantidad ingresada

            Stock = Stock + cantidad;



        }

        public void SalidaProducto(int cantidad)
        {
            //Cuando ingreso la cantidad, me va disminuyendo en el stock

            Stock = Stock - cantidad;
        }



        //public  DataTable Datos(int codex, string descrip)
        //{



        //    var dt = new DataTable();

        //    return dt;

        //}




        //public DataTable Datos(string descrip)
        //{

        //    var dt = new DataTable();

        //    return dt;

        //}


        public  DataTable dt(int codex, string descrip)
        {
            Codigo = codex;

            Descripcion = descrip;

            DataTable dt = new DataTable();

            

            return dt;
        }


        #endregion Metodos




    }


   
}


//El constructor de la subclase llaman al constructor de la clase padre