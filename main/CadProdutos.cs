using System;
using Data_atual;
using Digitais;
using Duraveis;
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

    public int GetCode(Produto produto){
        if(produto is Perecivel){
            Perecivel produtocast=(Perecivel)produto;
            return produtocast.GetCode();
        }
        if(produto is Digital){
            Digital produtocast=(Digital)produto;
            return produtocast.GetCode();
        }
        if(produto is Duravel){
            Duravel produtocast=(Duravel)produto;
            return produtocast.GetCode();
        }
        return 0;
    }
    

}