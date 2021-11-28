using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDominio
{
    class Postre:Plato
    {
        private bool llevaAgregado;

        public Postre(string nombre, string descripcion,double precioBase):base(nombre,descripcion,precioBase)
        {

        }

    }
}
