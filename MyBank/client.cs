public class Client{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo;

    public Client() {}

    public Client(string titular, int agencia, int conta, double saldo)
    {
        this.titular = titular;
        this.agencia = agencia;
        this.conta = conta;
        this.saldo = saldo;
    }

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else{
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar (double valor)
    {
        this.saldo += valor;
    }

    public bool Transfirir (double valor, Client contaDestino)
    {
        if(this.saldo < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
