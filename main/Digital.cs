using System;
using Produtos;

namespace Digitais;

public class Digital : Produto{
    protected float tamanho;
    protected string? formato; //ARUMARR NULL !!!
    protected string? link; // !!aqui tbm null!!
    public Digital(float tamanho, string formato, string link, int codigo, string descricao, string fabricante):base(codigo, descricao, fabricante){
        this.tamanho= tamanho;
        this.formato=formato;
        this.link=link;
        this.descricao=descricao;
        this.fabricante=fabricante;
        this.codigo=codigo;
    }


    public override void ExibirDetalhes(){
        Console.WriteLine($"Codigo: {this.codigo}\nDescrição: {this.descricao}\nLink: {this.link}\nTamanho: {this.tamanho}\nFormato: {this.formato}\nFabricante: {this.fabricante}");

    }
}

