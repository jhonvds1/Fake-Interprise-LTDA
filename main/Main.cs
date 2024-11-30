using System;
using Pereciveis;
using Produtos;
using Data_atual;
using Digitais;
using Duraveis;

namespace Main;

public abstract class Master{
    static void Main(string[] args)
    {
        // int codigo;
        // string? descricao;
        // string? fabricante;
        // string? entrada;
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
       // Data data = new Data(30,11,2024);
        // Perecivel teste = new Perecivel(1, "Melhor batata doce da região", "Produtor de batata doce",data,true,"Batata");
        //Digital teste = new Digital(20.3f,"PDF","link.com",1,"Material de estudos","Harvard");
        //Duravel teste = new Duravel(2,"Plástico",false,1,"Carrinho","China");
        //teste.ExibirDetalhes();


        Console.ReadLine();
    }
}