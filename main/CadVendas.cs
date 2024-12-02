using System;
using Vendas;

namespace CadsVendas;

public class CadVendas{

    protected Venda[] vendas = new Venda[100];


    public void ExibirVendas(int vendastotais){
        for(int i=0;i<vendastotais;i++){
        vendas[i].ExibirVenda(vendastotais);
        }
    }




}

