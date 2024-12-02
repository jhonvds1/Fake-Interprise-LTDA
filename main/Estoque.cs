using System;
using System.Security.Cryptography.X509Certificates;
using itensEstoque;

namespace ESTOQUE;

public class Estoque{
    protected int itensCadastrados=0;
    protected ItemEstoque[] cadastro = new ItemEstoque[10000]; // ARRUMAR NULL AQUI!!!!!!!

    public void insere(ItemEstoque item){
        this.cadastro[itensCadastrados]=item;
        itensCadastrados++;
    }

    public ItemEstoque GetItem(int posicao){
        if(posicao<0 || posicao>=cadastro.Length){
             throw new ArgumentOutOfRangeException("Posição inexistente");
        }
        if (cadastro == null){
            throw new InvalidOperationException("Não há produto na posição especificada.");
        }
        ItemEstoque produto = cadastro[posicao];
        return produto;
    }

    public int GetQuantidade(int codigo){
        int quantidade=0;
        for(int i=0;i<itensCadastrados;i++){
            if(cadastro[i].GetCodeProduto()==codigo){
                quantidade = cadastro[i].GetQuantidade();
            }
        }
        return quantidade;
    }

    public int GetItensCadastrados(){
        return itensCadastrados;
    }


    public double GetValor(int codigo){
        double valor=0;
        for(int i=0;i<itensCadastrados;i++){
            if(cadastro[i].GetCodeProduto()==codigo){
                valor = cadastro[i].GetValor();
            }
        }
        return valor;
    }

    public void RemoverEstoque(int quantidade, int codigo){
        for(int i=0;i<itensCadastrados;i++){
            if(cadastro[i].GetCodeProduto()==codigo){
                cadastro[i].RemoverQuantidade(quantidade);
            }
        }
    }

}