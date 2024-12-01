using System;
using Produtos;

namespace Duraveis;

public class Duravel : Produto{
    protected int garantia;
    protected string? material; //ARRUAML NULL AQUI!!!
    protected bool? manutencao;
    public Duravel(int garantia, string material, bool? manutencao, int codigo, string descricao, string fabricante):base(codigo, descricao, fabricante){
        this.garantia=garantia;
        this.material=material;
        this.manutencao=manutencao;
        this.codigo=codigo;
        this.descricao=descricao;
        this.fabricante=fabricante;


    }

    public int GetCode(){
        return this.codigo;
    }

    public override void ExibirDetalhes(){
        Console.WriteLine($"Codigo: {this.codigo}\nDescrição: {this.descricao}\nMaterial: {this.material}\nGarantia: {this.garantia}\nManutenção: {this.manutencao}\nFabricante: {this.fabricante}");

    }
}