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
        private byte temperatura;
        #endregion

        #region Propiedades
        public byte Temperatura { 
            get => temperatura;              //limites de lectura
            set                              //limites de escritura
            {
                if (0 < value && value < 25)
                    temperatura = value;
                else
                    temperatura = 20;
            }
        }
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
            Temperatura = 20;
            if(mantenimiento == true)
                Console.WriteLine("Entrando en modo mantenimiento...");
                Console.WriteLine("Cambiando temperatura...");
            LimpiarDisplay();
            for (int i = 0; i < 20; i++)
            {
                Temperatura++;
            }
            Console.WriteLine("Mostrando temperatura {0} [°C]", Temperatura);
        }

        #endregion
    }
}
