using System;
using Produtos;

namespace ItensVenda;

public class ItemVenda{
    protected Produto item;
    protected int quantidade;
    protected double valor;

    public ItemVenda(Produto item, int quantidade, double valor){
        this.item=item;
        this.quantidade=quantidade;
        this.valor=valor;
    }

    public void ExibirVenda(){
        Console.WriteLine($"Item: {this.item}\nQuantidade: {this.quantidade}\nValor: {this.valor}");
    }

}