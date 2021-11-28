using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
     class Actividad
    {
        private int id;
        private static int ultimoId=1;
        private string nombre;
        private DateTime fecha;
        private Lugar lugar;
        private Categoria categoria;
        private string edadMinima;
        private static int precioBase=220;
        private int likes;

        public Actividad( string nombre, DateTime fecha, Lugar lugar, Categoria nombreCategoria, string edadMinima, int likes)
        {
            this.id = ultimoId;
            ultimoId++;
            this.nombre = nombre;
            this.fecha = fecha;
            this.lugar = lugar;
            this.categoria = nombreCategoria;
            this.edadMinima = edadMinima;
            this.likes = likes;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public DateTime Fecha 
        {
            get { return this.fecha; }
        }
        public string EdadMinima
        {
            get { return this.edadMinima; }
        }
        public string CategoriaNombre
        {
            get { return this.categoria.Nombre; }
        }

        public override string ToString()
        {
            return "El evento " + this.nombre +", de tipo: " +this.categoria.Nombre + ". En el lugar " + this.lugar.ToString()+ ", apto para: "+ this.edadMinima + ". Tendra una entrada de valor: $ " + Actividad.precioBase + ". El dia " + this.fecha;
        }


    }
}
