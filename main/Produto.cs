using System;

namespace Produtos;

public abstract class Produto{
    protected int codigo{get;set;}
    protected string descricao{get;set;}
    protected string fabricante{get;set;}

    public Produto(int codigo, string descricao, string fabricante){
        this.codigo=codigo;
        this.descricao=descricao;
        this.fabricante=fabricante;
    }

    public abstract void ExibirDetalhes();

}