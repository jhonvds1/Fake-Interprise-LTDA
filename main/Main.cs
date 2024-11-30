using System;
using Pereciveis;
using Produtos;


namespace Main;

public abstract class Master{
    static void Main(string[] args)
    {
        int codigo;
        string? descricao;
        string? fabricante;
        string? entrada;
        // do{
        //     Console.WriteLine("Digite o codigo: ");
        //     entrada=Console.ReadLine();
        // }while(!int.TryParse(entrada, out codigo));

        // do{
        //     Console.WriteLine("Digite a descrição: ");
        //     descricao=Console.ReadLine();
        // }while(string.IsNullOrEmpty(descricao));

        // do{
        //     Console.WriteLine("Digite o fabricante: ");
        //     fabricante=Console.ReadLine();
        // }while(string.IsNullOrEmpty(fabricante));

      //  Perecivel teste = new Perecivel(codigo, descricao, fabricante,Data, true, "batata");
       // teste.ExibirDetalhes();
        

        Console.ReadLine();
    }
}