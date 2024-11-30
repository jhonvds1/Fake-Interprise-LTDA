using System;
using System.Reflection.Metadata;
using Data_atual;
using Produtos;

namespace Pereciveis;

public class Perecivel : Produto{
    private Data dataValidade;
    private bool organico;
    private string? ingredientes; // ARRUMAR O NULL AQUIIII !!!!!!!!!

    public Perecivel(int codigo, string descricao, string fabricante, Data dataValidade, bool organico, string ingredientes) : base(codigo, descricao, fabricante){
        this.ingredientes= ingredientes;
        this.organico=organico;
        this.dataValidade=dataValidade;
        this.codigo=codigo;
        this.descricao=descricao;
        this.fabricante=fabricante;
    }



    public int DiasateVencimento(Data dataref){
        DateTime validade = dataValidade.ParaDateTime();
        DateTime referencia = dataref.ParaDateTime();
        TimeSpan diferenca = validade - referencia;
        return diferenca.Days; 
    }

    public override void ExibirDetalhes(){
        Console.WriteLine($"data de validade: {this.dataValidade} organico: {this.organico} ingredientes: {this.ingredientes} codigo: {this.codigo} descrição: {this.descricao} fabricante: {this.fabricante}");
    }


}