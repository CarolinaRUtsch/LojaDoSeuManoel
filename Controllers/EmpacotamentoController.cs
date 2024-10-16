using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class EmpacotamentoController : ControllerBase
{
    private readonly EmpacotamentoService _empacotamentoService;

    public EmpacotamentoController()
    {
        _empacotamentoService = new EmpacotamentoService();
    }

    [HttpPost]
    public IActionResult EmpacotarPedidos([FromBody] PedidosRequest request)
    {
        var resultado = new List<object>();

        foreach (var pedido in request.Pedidos)
        {
            var caixas = _empacotamentoService.EmpacotarProdutos(pedido.Produtos);
            resultado.Add(new
            {
                PedidoId = pedido.pedido_id,
                Caixas = caixas.Select(caixa => new
                {
                    CaixaId = caixa.CaixaId,
                    Produtos = caixa.Produtos.Select(produto => produto.produto_id).ToList()
                }).ToList()
            });
        }

        return Ok(resultado);
    }

}
