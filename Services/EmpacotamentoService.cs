using System.Collections.Generic;

public class EmpacotamentoService
{
    private readonly List<Caixa> _caixasDisponiveis = new List<Caixa>
{
    new Caixa { CaixaId = "Caixa 1", Dimensoes = new Dimensoes { Altura = 30, Largura = 40, Comprimento = 80 } },
    new Caixa { CaixaId = "Caixa 2", Dimensoes = new Dimensoes { Altura = 80, Largura = 50, Comprimento = 40 } },
    new Caixa { CaixaId = "Caixa 3", Dimensoes = new Dimensoes { Altura = 50, Largura = 80, Comprimento = 60 } }
};
    public List<Caixa> EmpacotarProdutos(List<Produto> produtos)
    {
        var resultadoCaixas = new List<Caixa>();

        foreach (var produto in produtos)
        {
            var caixaEscolhida = EncontrarMelhorCaixa(produto);
            if (caixaEscolhida != null)
            {
                caixaEscolhida.Produtos ??= new List<Produto>();
                caixaEscolhida.Produtos.Add(produto);
                if (!resultadoCaixas.Contains(caixaEscolhida))
                {
                    resultadoCaixas.Add(caixaEscolhida);
                }
            }
            else
            {
                resultadoCaixas.Add(new Caixa
                {
                    CaixaId = null,
                    Produtos = new List<Produto> { produto },
                });
            }
        }

        return resultadoCaixas;
    }

    private Caixa EncontrarMelhorCaixa(Produto produto)
    {
        foreach (var caixa in _caixasDisponiveis)
        {
            if (produto.Dimensoes.Altura <= caixa.Dimensoes.Altura &&
                produto.Dimensoes.Largura <= caixa.Dimensoes.Largura &&
                produto.Dimensoes.Comprimento <= caixa.Dimensoes.Comprimento)
            {
                return caixa;
            }
        }

        return null;
    }

}
