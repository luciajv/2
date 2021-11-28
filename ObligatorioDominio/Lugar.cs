using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
     abstract class Lugar
   {
        private int id;
        private string nombre;
        private double dimensiones;

        public Lugar(int id, string nombre, double dimensiones)
        {
            this.id = id;
            this.nombre = nombre;
            this.dimensiones = dimensiones;
        }

        public int Id
        {
            get
            {
            
                return this.id;
            }
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
    
}
