public class Banco {
    private List<Conta> contas;

    private List<Cliente> clientes;

    public Banco(){
        this.contas = new List<Conta>();
        this.clientes = new List<Cliente>();
    }

    public void addConta(Conta c){
        contas.Add(c);
    }

    public void addCliente(Cliente c){
        clientes.Add(c);
    }

    public List<Conta> Contas{
        get { return contas; }
    }

    public void clientesPorNome(){
        foreach(Cliente c in clientes){
            Console.WriteLine(c.Nome);
        }
    }

    public void clientesNomeConta(){
        foreach(Cliente c in clientes){
            Console.WriteLine($"Cliente: {c.Nome}; Contas (Quant): {c.Contas.Count}");
        }
    }

    public void clienteValoresTotais(){
        foreach(Cliente c in clientes){
            int total = 0;
            foreach(Conta co in c.Contas){
                total += co.Saldo;
            }
            Console.WriteLine($"Cliente: {c.Nome}; Valor Total: {total}");
        }
    }

    public void clienteValoresTotaisTipoConta(){
        foreach(Cliente c in clientes){
            int totalPop = 0;
            int totalEsp = 0;
            int totalSim = 0;

            foreach( Conta co in c.Contas){
                if(co.Tipo == TipoConta.Poupanca){
                    totalPop += co.Saldo;
                } 
                if (co.Tipo == TipoConta.Especial){
                    totalEsp += co.Saldo;
                }
                if (co.Tipo == TipoConta.Simples){
                    totalSim += co.Saldo;
                }
            }

            Console.WriteLine($"Total Poupança {c.Nome}: {totalPop}");
            Console.WriteLine($"Total Especial {c.Nome}: {totalEsp}");
            Console.WriteLine($"Total Simples {c.Nome}: {totalSim}");
        }
    }
}