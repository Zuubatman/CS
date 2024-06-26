public class ContaPoupança : Conta {

    private int taxaJuros;

    public ContaPoupança(int id, int taxaJuros) : base (id, TipoConta.Poupanca){
        this.taxaJuros = taxaJuros;
    }

}