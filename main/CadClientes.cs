using System;
using Clientes;
using Produtos;

namespace CadsClientes;

public class CadClientes{
    protected Cliente[] cadastro = new Cliente[100];
    protected int clientesCadastrados=0;

    public void insere(Cliente cliente){
        
        this.cadastro[clientesCadastrados]=cliente;
        clientesCadastrados++;

    }

    public Cliente GetCliente(int posicao){
        if(posicao<0 || posicao>=cadastro.Length){
             throw new ArgumentOutOfRangeException("Posição inexistente");
        }
        if (cadastro == null){
            throw new InvalidOperationException("Não há produto na posição especificada.");
        }
        Cliente cliente = cadastro[posicao];
        return cliente;
    }

    public int GetCode(int posicao){
        return cadastro[posicao].GetCode();
    }

    public Cliente GetClienteByCode(int code){
        int cliente=0;
        for(int i=0;i<clientesCadastrados;i++){
            if(cadastro[i].GetCode()==code){
                cliente=i;
            }
        }
        return cadastro[cliente];
    }

}