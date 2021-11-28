using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
     class Cerrado : Lugar
    {
        private bool accesible;
        private static int aforo=50;
        private int valorMantenimiento;

        
        public Cerrado(int id, string nombre, double dimensiones, bool accesible, int valorMantenimiento) : base(id, nombre, dimensiones)
        {
            this.accesible = accesible;
            this.valorMantenimiento = valorMantenimiento;
        }

        public static int Aforo
        {
            set { Cerrado.aforo = value; }
            get { return Cerrado.aforo; }
        }
    }

}
