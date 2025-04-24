using System;
using System.Collections.Generic;

namespace API_ECommerce.Models;

public partial class ItemPedido
{
    public int IdItem { get; set; }

    public int? IdPedido { get; set; }

    public int? IdProduto { get; set; }

    public int? Quantidade { get; set; }

    public virtual Pedido? Pedido { get; set; }

    public virtual Produto? Produto { get; set; }
}
