using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDominio
{
    public class Restaurant
    {
        private List<ClientePedido> clientes = new List<ClientePedido>();
        private List<Pedido> pedidos = new List<Pedido>();
        private List<Plato> platos = new List<Plato>();

        public Restaurant()
        {
            CargarDatosPruebaPlato();
            CargarDatosPruebaPlatoMinuta();
        }
        private void CargarDatosPruebaPlato()
        {
            this.AltaPlato("Milanesa", "Carne con pan rallado", 300);
        }
        private void CargarDatosPruebaPlatoMinuta()
        {
            this.AltaPlatoMinuta("Papas fritas", "Papas fritas en aceite", 80, "Milanesa");
        }
        private void CargarDatosPlatoGourmet()
        {
            this.AltaPlatoGourmet("Strogonoff de pollo", "Pollo en salsa de hongos y crema de leche", 500, false);
        }


        private void AltaPlato(string nombre, string descripcion, double precioBase)
        {
            //Verificar parametros
            if (nombre != "" && descripcion != "" && precioBase > 0)
            {
                //verificar existencia 
                if (ExistePlato(nombre) == null)
                { //creamos la instancia
                    Plato miPlato = new Plato(nombre, descripcion, precioBase);
                    //guardabamos en la lista
                    platos.Add(miPlato);
                }

            }
        }
        private void AltaPlatoMinuta(string nombre, string descripcion, double precioBase, string nombrePostre)
        {
            if (nombre != "" && descripcion != "" && precioBase > 0 && nombrePostre != "")
            {
                if (ExistePlato(nombre) == null)
                {
                    //Verificar si existe el postre
                    Plato miPostre = ExistePlato(nombrePostre);
                    if (miPostre != null && miPostre is Postre)
                    {
                        Minuta miMinuta = new Minuta(nombre, descripcion, precioBase, miPostre);
                        platos.Add(miMinuta);
                    }

                }
            }

        }

        private void AltaPlatoGourmet(string nombre, string descripcion, double precioBase, bool aderezos)
        {
            if (nombre != "" && descripcion != "" && precioBase > 0)
            {
                if (ExistePlato(nombre) == null)
                {

                    Gourmet miGourmet = new Gourmet(nombre, descripcion, precioBase)
                    platos.Add(miGourmet);
                }



            }
        }
        
        
        private Plato ExistePlato(string nombre)
        {
            Plato platoBuscado = null;
            int i = 0;
            while(i<platos.Count && platoBuscado==null)
            {
                if (platos[i].Nombre.ToUpper() == nombre.ToUpper())
                {
                    platoBuscado = platos[i];
                }
                i++;
            }
            return platoBuscado;
        }
        public string MostrarPlatos()
        {
            string misPlatos = "";
            for(int i = 0; i < platos.Count; i++)
            {
                misPlatos += platos[i] + "\n";
            }
            return misPlatos;
        }
    }
}
