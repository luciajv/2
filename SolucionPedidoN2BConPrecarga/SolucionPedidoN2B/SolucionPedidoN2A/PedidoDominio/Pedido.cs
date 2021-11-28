using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDominio
{
    class Pedido
    {
        private int id;
        private static int ultimoId;
        private DateTime fecha;
        private ClientePedido cliente;
        private List<PlatoCantidad> platosSolicitados = new List<PlatoCantidad>();
    }
}
