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

}