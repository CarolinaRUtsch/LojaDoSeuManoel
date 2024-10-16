public class Produto
{
    public string produto_id { get; set; }
    public Dimensoes Dimensoes { get; set; }
}

public class Dimensoes
{
    public int Altura { get; set; }
    public int Largura { get; set; }
    public int Comprimento { get; set; }
}
