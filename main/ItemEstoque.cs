using System;
using Produtos;

namespace itensEstoque;

public class ItemEstoque{
    protected Produto item;
    protected int quantidade;
    protected double valor;

    public ItemEstoque(Produto item, int quantidade, double valor){
        this.item=item;
        this.quantidade=quantidade;
        this.valor=valor;
    }

}