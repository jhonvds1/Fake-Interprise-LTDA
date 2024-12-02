using System;
using Clientes;
using ItensVenda;
using Data_atual;

namespace Vendas;

public class Venda{
    protected Cliente cliente;
    protected ItemVenda[] itens;
    protected double valorTotal;
    protected Data dataVenda;

    public Venda(Cliente cliente, ItemVenda[] itens, double valorTotal, Data data){
        this.cliente=cliente;
        this.itens=itens;
        this.valorTotal=valorTotal;
        this.dataVenda=data;
    }

    public void ExibirVenda(int vendas){
        Console.WriteLine($"Cliente: {this.cliente}");
        for(int i=0;i<vendas;i++){
            itens[i].ExibirVenda();
        }
        Console.WriteLine($"Valor total: {this.valorTotal}");
        Console.WriteLine($"Data: {this.dataVenda.ParaDateTime()}");
    }


}