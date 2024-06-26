public class ContaEspecial : ContaCorrente { 

    private int limiteCredito;

    public ContaEspecial(int id, int limiteCredito) : base(id, TipoConta.Especial) {
        this.limiteCredito = limiteCredito;
    } 
    
}