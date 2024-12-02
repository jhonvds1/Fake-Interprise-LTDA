using System;
using Produtos;
using ESTOQUE;
using Pereciveis;
using Digitais;
using Duraveis;
using System.Collections.Concurrent;


namespace itensEstoque;

public class ItemEstoque{
    protected Produto item;
    protected int quantidade;
    protected double valor;

    private Estoque estoque = new Estoque();

    public ItemEstoque(Produto item, int quantidade, double valor){
        this.item=item;
        this.quantidade=quantidade;
        this.valor=valor;
    }

    public int GetQuantidade(){
        return this.quantidade;
    }

    public void RemoverQuantidade(int quantidade){
        this.quantidade=this.quantidade-quantidade;
    }

    public double GetValor(){
        return this.valor;
    }

    public int GetCodeProduto(){
        Produto aux = this.item;
        int codigo=0;
        for(int i=0;i<estoque.GetItensCadastrados();i++){
            if(aux is Perecivel perecivel){
                codigo=perecivel.GetCode();
            }
            if(aux is Duravel duravel){
                codigo=duravel.GetCode();
            }
            if(aux is Digital digital){
                codigo=digital.GetCode();
            }
        }
        return codigo;
    }

}