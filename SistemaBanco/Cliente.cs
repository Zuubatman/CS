public class Cliente { 
    private string nome;
    private DateTime dataNascimento; 

    private List<Conta> contas;

    public Cliente(string nome, DateTime dataNas){
        this.nome = nome;
        this.dataNascimento = dataNas;
        this.contas = new List<Conta>();
    }

    public void addConta(Conta c){
        contas.Add(c);
    }

    public string Nome{
        get{ return nome;}
    }

    public List<Conta> Contas{
        get { return contas; }
    }

}