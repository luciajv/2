using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
    class Abierto:Lugar
    {
        private static int precioButaca = 200;

        public Abierto(int id, string nombre, double dimensiones) : base (id, nombre, dimensiones)
        {

        }

        public static int PrecioButaca
        {
            set { Abierto.precioButaca = value; }
            get { return Abierto.precioButaca; }
        }
    }



}
