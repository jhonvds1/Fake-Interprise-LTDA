using System;
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

}