using System.Collections.Generic;

public class PedidosRequest
{
    public int pedido_id { get; set; }

    public List<Pedido> Pedidos { get; set; }
}
