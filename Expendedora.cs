using System;
//using System.Threading;

namespace ExpendedoraG2_2024_1
{
    internal class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantProductos;
        private float precio;
        private float temperatura;
        #endregion

        #region Métodos
        private void Saludar()
        {
            Console.WriteLine("Bienvenido, elige un producto c:");
        }

        public string MostrarProducto()
        {
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais");
            Console.WriteLine("\nIngresa el código del producto: ");
            string codigo = Console.ReadLine();
            return codigo;
        }

        public void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", precio - 6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto válido");
                    break;
            }
        }

        public void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        #endregion

        #region Constructor
        public Expendedora()
        {
            marca = "AMS";
            precio = 18;

            Saludar();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}", marca);
            LimpiarDisplay();

            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }

        public Expendedora(bool mantenimiento)
        {
            if(mantenimiento == true)
                Console.WriteLine("Entrando en modo mantenimiento...");
        }

        #endregion
    }
}
