using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
     class Categoria
    {

        private string nombre;
        private string descripcion;

        public Categoria(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public override string ToString()
        {
            return this.nombre;
        }


    }

 }
