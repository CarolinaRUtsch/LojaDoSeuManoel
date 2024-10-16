using System.Collections.Generic;

public class Caixa
{
    public string CaixaId { get; set; }
    public List<Produto> Produtos { get; set; }
    public Dimensoes Dimensoes { get; set; }
}
