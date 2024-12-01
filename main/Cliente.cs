using System;
using Data_atual;
using Enderecos;

namespace Clientes;

public class Cliente{
    protected int codigo;
    protected string nome;
    protected Endereco endereco;
    protected string foneRes;
    protected string foneCelular;
    protected Data nascimento;

    public Cliente(int codigo, string nome, Data nascimento, Endereco endereco, string foneres, string foneCelular){
        this.codigo=codigo;
        this.nome=nome;
        this.nascimento=nascimento;
        this.endereco=endereco;
        this.foneCelular=foneCelular;
        this.foneRes=foneres;
    }

    public void ExibirDetalhes(){
        DateTime dataval = nascimento.ParaDateTime();
        string datafinal = dataval.ToString("dd/MM/yyyy");
        Console.WriteLine($"Codigo: {this.codigo}\nNome: {this.nome}\nData de nascimento: {datafinal}\nTelefone Residencial: {this.foneRes}\nTelefone Celular: {this.foneCelular}");
        this.endereco.ExibirDetalhes();
    }

}