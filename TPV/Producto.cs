using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV
{
    public class Producto
    {
        private string nombre;
        private int cantidad;
        private double precio;

        public Producto(string nombre, int cantidad, double precio)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
