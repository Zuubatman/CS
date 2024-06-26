public enum TipoConta 
{ 
    Poupanca,
    Especial,
    Simples
}

public abstract class Conta { 

    private int id;

    private DateTime dataAbertura; 

    private int saldo;

    private TipoConta tipo;

    public void Depositar(int valor){
        this.saldo += valor; 
    }

    public void Sacar(int valor){
        this.saldo -= valor;
    }

    public Conta(int Id, TipoConta tipo){
        this.id = Id;
        this.saldo = 0;
        this.dataAbertura = DateTime.Now;
        this.tipo = tipo;
    }

    public int Saldo {
        get { return saldo; }
    }

    public int Id {
        get {return id; }
    }

    public TipoConta Tipo {
        get { return tipo; }
    } 

}