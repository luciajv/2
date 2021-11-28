using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
     class Compra
    {
        private int id;
        private int cantidad;
        private Usuario usuarioCompra;
        private DateTime fechaCompra;
        private bool estado;
        private int precioFinal;
        private Actividad actividad;

        public Compra(int id, int cantidad, bool estado, int precioFinal,DateTime fechaCompra ,Usuario usuarioCompra ,Actividad actividad)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.estado = estado;
            this.precioFinal = precioFinal;
            this.fechaCompra = fechaCompra;
            this.usuarioCompra = usuarioCompra;
            this.actividad = actividad;
        }
        public int Id
        {
            get { return this.id; }
        }


    }

   
}
