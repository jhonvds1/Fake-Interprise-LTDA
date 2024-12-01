using System;

namespace Data_atual;

public class Data{
    protected int dia,mes,ano;

    public Data(int dia, int mes, int ano){
        this.dia=dia;
        this.mes=mes;
        this.ano=ano;
    }

    public DateTime ParaDateTime(){
        return new DateTime(this.ano, this.mes, this.dia);
    }

    public int RetornarDias(){
        DateTime dataAtual = DateTime.Now;
        DateTime validade = ParaDateTime();
        TimeSpan diferenca = validade-dataAtual;
        return diferenca.Days;
        

    }

    public bool Valida(){

        try{
            DateTime data = new DateTime(this.ano, this.mes, this.dia);
            return true;
        }catch{
            return false;
        }
    }
}