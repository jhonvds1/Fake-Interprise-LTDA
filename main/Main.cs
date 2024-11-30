using System;
using Pereciveis;
using Produtos;
using Data_atual;
using Digitais;
using Duraveis;
using System.Threading;
using CadastrosProdutos;
using System.Xml.Serialization;
using System.Dynamic;

namespace Main;

public abstract class Master{
    static void Main(string[] args)
    {
        CadProdutos cadprodutos = new CadProdutos();
        int produtoscadastrados=0;
        int escolha=-1;
        do{
            Console.WriteLine("=================Fake Interprise=================");
            Console.WriteLine("Digite 1 para cadastrar um produto");
            Console.WriteLine("Digite 2 para Listas os produtos");
            Console.WriteLine("Digite 3 para ver produtos vencendo");
            Console.WriteLine("Digite 4 para cadastrar um cliente");
            Console.WriteLine("Digite 5 para Listar os clientes");
            Console.WriteLine("Digite 6 para cadastrar o estoque de produtos");
            Console.WriteLine("Digite 7 para cadastrar uma venda");
            Console.WriteLine("Digite 8 para Listar as vendas realizadas");
            Console.WriteLine("Digite 9 para fechar");
            Console.WriteLine("==================================================");    
            string? entrada = Console.ReadLine();
            if(!string.IsNullOrEmpty(entrada)){
                try{
                    escolha = int.Parse(entrada);
                }catch(FormatException){
                    Console.WriteLine("Entrada inválida\n");
                    Thread.Sleep(1000);
                    
                }
                }else{
                    Console.WriteLine("Entrada inválida");
                    Thread.Sleep(1000);
                }
        
            switch(escolha){
                case 1:
                    int codigo=-1,garantia=-1;
                    int verificador=0;
                    string? material,descricao,fabricante,link,formato;
                    float tamanho = -0.1f;
                    bool? manutencao=null;
                    int escolhap=-1;
                    int dia=-1, mes=-1, ano=-1;
                    do{
                        Console.WriteLine("Digite 1 para cadastrar um produto Durável");
                        Console.WriteLine("Digite 2 para cadastrar um produto perecível");
                        Console.WriteLine("Digite 3 para cadastrar um produto Digital");
                        Console.WriteLine("Digite 4 para voltar");
                        entrada = Console.ReadLine();
                        if(!string.IsNullOrEmpty(entrada)){
                            try{
                            escolhap = int.Parse(entrada);
                            }catch(FormatException){
                                Console.WriteLine("Entrada inválida\n");
                                Thread.Sleep(1000);
                            }
                        }else{
                            Console.WriteLine("Entrada inválida");
                            Thread.Sleep(1000);
                        }

                    
                        switch(escolhap){
                            case 1:
                                Console.WriteLine("Digite o código do produto");
                                entrada = Console.ReadLine();
                                if(!string.IsNullOrEmpty(entrada)){
                                    try{
                                    codigo = int.Parse(entrada);
                                    }catch(FormatException){
                                        Console.WriteLine("Código em inteiros\n");
                                        Thread.Sleep(1000);
                                    }
                                }else{
                                    Console.WriteLine("Digite o código");
                                    Thread.Sleep(1000);
                                }
                                do{
                                    Console.WriteLine("Digite a descrição do produto");
                                        descricao=Console.ReadLine();
                                }while(string.IsNullOrEmpty(descricao));
                                do{
                                    Console.WriteLine("Digite o fabricante");
                                    fabricante=Console.ReadLine();
                                }while(string.IsNullOrEmpty(fabricante));
                                do{
                                    Console.WriteLine("Digite o material do produto");
                                    material=Console.ReadLine();
                                }while(string.IsNullOrEmpty(material));
                                
                                Console.WriteLine("Digite a garantia do produto (em meses)");
                                entrada=Console.ReadLine();
                                if(!string.IsNullOrEmpty(entrada)){
                                    try{
                                    garantia = int.Parse(entrada);
                                    }catch(FormatException){
                                        Console.WriteLine("Código a garantia em meses\n");
                                        Thread.Sleep(1000);
                                    }
                                }else{
                                    Console.WriteLine("Digite a garantia");
                                    Thread.Sleep(1000);
                                }

                                do{
                                    Console.WriteLine("Digite se o produto precisa de manutenção (sim ou não)");
                                    entrada=Console.ReadLine();
                                    if(!string.IsNullOrEmpty(entrada)){
                                        if(char.ToLower(entrada[0])=='s'){
                                            manutencao=true;
                                            verificador=1;
                                        }else if(char.ToLower(entrada[0])=='n'){
                                            manutencao=false;
                                            verificador=1;
                                        }else{
                                            Console.WriteLine("Informe com sim ou não");
                                            verificador=0;
                                        }
                                    }else{
                                        verificador=0;
                                    }
                                }while(verificador==0);
                                Duravel duravel = new Duravel(garantia,material,manutencao,codigo,descricao,fabricante);
                                if(produtoscadastrados<=100){
                                    cadprodutos.Insere(duravel);
                                    produtoscadastrados++;
                                }else{
                                    Console.WriteLine("Não é possível cadastrar mais produtos");
                                }
                                break;
                            case 2:
                                string ingredientes;
                                bool? organico=null;
                                Console.WriteLine("Digite o código do produto");
                                entrada = Console.ReadLine();
                                if(!string.IsNullOrEmpty(entrada)){
                                    try{
                                    codigo = int.Parse(entrada);
                                    }catch(FormatException){
                                        Console.WriteLine("Código em inteiros\n");
                                        Thread.Sleep(1000);
                                    }
                                }else{
                                    Console.WriteLine("Digite o código");
                                    Thread.Sleep(1000);
                                }
                                do{
                                    Console.WriteLine("Digite a descrição do produto");
                                        descricao=Console.ReadLine();
                                }while(string.IsNullOrEmpty(descricao));
                                do{
                                    Console.WriteLine("Digite o fabricante");
                                    fabricante=Console.ReadLine();
                                }while(string.IsNullOrEmpty(fabricante));
                                do{
                                    Console.WriteLine("Digite se o produto é orgânico (sim ou não)");
                                    entrada=Console.ReadLine();
                                    if(!string.IsNullOrEmpty(entrada)){
                                        if(char.ToLower(entrada[0])=='s'){
                                            manutencao=true;
                                            verificador=1;
                                        }else if(char.ToLower(entrada[0])=='n'){
                                            manutencao=false;
                                            verificador=1;
                                        }else{
                                            Console.WriteLine("Informe com sim ou não");
                                            verificador=0;
                                        }
                                    }else{
                                        verificador=0;
                                    }
                                }while(verificador==0);
                                do{
                                    Console.WriteLine("Digite os ingredientes (Separados por vírgula)");
                                    ingredientes=Console.ReadLine();
                                }while(string.IsNullOrEmpty(ingredientes));
                                
                                do{
                                    Console.WriteLine("Digite o dia que o produto vence: ");
                                    entrada=Console.ReadLine();
                                    if(!string.IsNullOrEmpty(entrada)){
                                        try{
                                        dia = int.Parse(entrada);
                                        }catch(FormatException){
                                            Console.WriteLine("Digite o dia\n");
                                            Thread.Sleep(1000);
                                        }
                                    }else{
                                        Console.WriteLine("Digite o dia");
                                        Thread.Sleep(1000);
                                    }
                                }while(dia==-1);

                                do{
                                    Console.WriteLine("Digite o mês que o produte vence: ");
                                    entrada=Console.ReadLine();
                                    if(!string.IsNullOrEmpty(entrada)){
                                        try{
                                        mes = int.Parse(entrada);
                                        }catch(FormatException){
                                            Console.WriteLine("Digite o mes\n");
                                            Thread.Sleep(1000);
                                        }
                                    }else{
                                        Console.WriteLine("Digite o mes");
                                        Thread.Sleep(1000);
                                    }
                                }while(mes==0.1);

                                do{
                                    Console.WriteLine("Digite o ano que o produto vence: ");
                                    entrada=Console.ReadLine();
                                    if(!string.IsNullOrEmpty(entrada)){
                                        try{
                                        ano = int.Parse(entrada);
                                        }catch(FormatException){
                                            Console.WriteLine("Digite o ano\n");
                                            Thread.Sleep(1000);
                                        }
                                    }else{
                                        Console.WriteLine("Digite o ano");
                                        Thread.Sleep(1000);
                                    }
                                }while(ano==-0.1);
                                Data data = new Data(dia,mes,ano);
                                Perecivel perecivel = new Perecivel(codigo,descricao,fabricante,data,organico,ingredientes);
                                if(produtoscadastrados<=100){
                                    cadprodutos.Insere(perecivel);
                                    produtoscadastrados++;
                                }else{
                                    Console.WriteLine("Não é possível cadastrar mais produtos");
                                }


                                break;
                            case 3:
                                Console.WriteLine("Digite o código do produto");
                                entrada = Console.ReadLine();
                                if(!string.IsNullOrEmpty(entrada)){
                                    try{
                                    codigo = int.Parse(entrada);
                                    }catch(FormatException){
                                        Console.WriteLine("Código em inteiros\n");
                                        Thread.Sleep(1000);
                                    }
                                }else{
                                    Console.WriteLine("Digite o código");
                                    Thread.Sleep(1000);
                                }
                                do{
                                    Console.WriteLine("Digite a descrição do produto");
                                        descricao=Console.ReadLine();
                                }while(string.IsNullOrEmpty(descricao));
                                do{
                                    Console.WriteLine("Digite o fabricante");
                                    fabricante=Console.ReadLine();
                                }while(string.IsNullOrEmpty(fabricante));
                                do{
                                    Console.WriteLine("Digite o link do produto: ");
                                    link=Console.ReadLine();
                                }while(string.IsNullOrEmpty(link));
                                do{
                                    Console.WriteLine("Digite o formato: ");
                                    formato=Console.ReadLine();
                                }while(string.IsNullOrEmpty(formato));

                                do{
                                    Console.WriteLine("Digite o tamanho (em Mb)");
                                    entrada=Console.ReadLine();
                                    if(!string.IsNullOrEmpty(entrada)){
                                        try{
                                        tamanho = int.Parse(entrada);
                                        }catch(FormatException){
                                            Console.WriteLine("Digite o tamanho em Mb\n");
                                            Thread.Sleep(1000);
                                        }
                                    }else{
                                        Console.WriteLine("Digite o tamanho");
                                        Thread.Sleep(1000);
                                    }
                                }while(tamanho==-0.1f);
                                Digital digital = new Digital(tamanho,formato,link,codigo,descricao,fabricante);
                                if(produtoscadastrados<=100){
                                    cadprodutos.Insere(digital);
                                    produtoscadastrados++;
                                }else{
                                    Console.WriteLine("Não é possível cadastrar mais produtos");
                                }
                                break;
                            default:
                                Console.WriteLine("Digite uma opção entre 1 e 3");
                                break;

                        }
                    }while(escolhap!=4);

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Digite uma opção entre 1 e 9");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;

            }
        }while(escolha!=9);
     
     
        Console.ReadLine();



    }
}