public class client{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo;

    public client() {}

    public client(string titular, int agencia, int conta, double saldo)
    {
        this.titular = titular;
        this.agencia = agencia;
        this.conta = conta;
        this.saldo = saldo;
    }
}