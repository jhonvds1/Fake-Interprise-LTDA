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


}