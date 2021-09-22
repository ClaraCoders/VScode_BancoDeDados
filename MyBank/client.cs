public class Client{

    public double Conta { get; set; }
    public string Titular { get; set; }
    public int Agencia { get; set; }

    private double _saldo;

    public double Saldo { 
        get{
            return this._saldo;
        }
        set{
            if(value >= 0){
                this._saldo = value;
            }
        }
    }
  
    public Client() {}

    public Client(string client_titular, int client_agencia, double client_saldo)
    {
        Titular = client_titular;
        Agencia = client_agencia;
        Saldo = client_saldo;
    }

    
    public bool Sacar(double valor)
    {
        if (this.Saldo < valor)
        {
            return false;
        }
        else{
            this.Saldo -= valor;
            return true;
        }
    }

    public void Depositar (double valor)
    {
        this.Saldo += valor;
    }

    public bool Transfirir (double valor, Client contaDestino)
    {
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
    
}
