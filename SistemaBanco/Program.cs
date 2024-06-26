public class Program {
    public static void Main(string[] args){
        Banco b = new Banco();
        Cliente c1 = new Cliente("Jose", DateTime.Now);
        Cliente c2 = new Cliente("Aline", DateTime.Now);
        Cliente c3 = new Cliente("Carlos", DateTime.Now);
        Cliente c4 = new Cliente("Lavínia", DateTime.Now);


        b.addCliente(c1); 
        b.addCliente(c2); 
        b.addCliente(c3); 
        b.addCliente(c4); 

        ContaEspecial ce = new ContaEspecial(1, 500);
        ContaPoupança cp = new ContaPoupança(2, 1);
        ContaSimples cs = new ContaSimples(3);

        c1.addConta(ce);
        c1.addConta(cp);
        c1.addConta(cs);
        c2.addConta(ce);
        c3.addConta(cp);
        c3.addConta(cs);

        b.addConta(ce);
        b.addConta(ce);
        b.addConta(cp);
        b.addConta(cp);
        b.addConta(cs);
        b.addConta(cs);


        cp.Depositar(30);
        ce.Depositar(100);
        cs.Depositar(500);
        cs.Sacar(500);

        Console.WriteLine(ce.Saldo);
        Console.WriteLine(cp.Saldo);
        Console.WriteLine(cs.Saldo);
        Console.WriteLine(cs.Id);

        b.clientesPorNome();
        b.clientesNomeConta();
        b.clienteValoresTotais();
        b.clienteValoresTotaisTipoConta();

    }
}
