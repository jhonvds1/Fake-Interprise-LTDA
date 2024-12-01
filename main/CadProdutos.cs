using System;
using Data_atual;
using Pereciveis;
using Produtos;

namespace CadastrosProdutos;

public class CadProdutos{
    protected Produto[] cadastro = new Produto[100];
    protected int produtoscadastrados=0;

    public void Insere(Produto prod){
        this.cadastro[produtoscadastrados]=prod;
        produtoscadastrados++;
    }

    public Produto GetProduto(int posicao){
        if(posicao<0 || posicao>=cadastro.Length){
             throw new ArgumentOutOfRangeException("Posição inexistente");
        }
        if (cadastro == null){
            throw new InvalidOperationException("Não há produto na posição especificada.");
        }
        Produto produto = cadastro[posicao];
        return produto;
    }

}