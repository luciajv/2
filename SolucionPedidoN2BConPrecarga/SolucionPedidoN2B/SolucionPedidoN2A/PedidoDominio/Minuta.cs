using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDominio
{
    class Minuta:Plato
    {
        private Postre postre;
        public Minuta(string nombre, string descripcion,double precioBase, Plato miPostre) : base(nombre, descripcion, precioBase)
        {
            this.postre = (Postre) miPostre;
        }
    }
}
