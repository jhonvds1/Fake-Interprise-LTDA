using System;

namespace Enderecos;

public class Endereco{
    protected string rua;
    protected int numero;
    protected string complemento;
    protected string bairro;
    protected string cep;
    protected string cidade;
    protected string uf;

    public Endereco(string uf, string cidade, string bairro,string complemento,int numero,string rua,string cep){
        this.uf=uf;
        this.cidade=cidade;
        this.bairro=bairro;
        this.complemento=complemento;
        this.numero=numero;
        this.rua=rua;
        this.cep=cep;
    }

}