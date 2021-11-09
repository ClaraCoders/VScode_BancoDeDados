public class Client{

    public double Conta { get; set; }
    public string Titular { get; set; }
    public int Agencia { get; set; }

    public static double TComissao { get; set; }
    public static int TotalContas { get; set; }
    

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
  
    public Client(){}

    public Client(string client_titular, int client_agencia, double client_saldo, Funcionario funcionario)
    {
        /*this.titular = titular;*/ //No lugar de this, podemos apenas mudar o nome da variável para uma não existente
        Titular = client_titular;
        Agencia = client_agencia;
        Saldo = client_saldo;

        TotalContas ++;
        TComissao += client_saldo * 0.01;

        funcionario.Comissao += client_saldo * 0.01;
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
    { //o método não precisa de um retorno
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
