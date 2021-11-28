using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDominio
{
    class Plato
    {
        private string nombre;
        private string descripcion;
        private double precioBase;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public Plato(string nombre, string descripcion, double precioBase)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioBase = precioBase;
        }

        public override string ToString()
        {
            return this.nombre + "-" + this.descripcion;
        }
    }
}
