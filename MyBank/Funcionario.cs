public class Funcionario {
    
    public string Name { get; set; }
    public string CPF { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }

    private double _bonificacao; 

    public double Bonificacao { 
        get{
            return _bonificacao;
        }

        set{
            if (Cargo == "Vendedor"){
                _bonificacao += value * 0.02; // value é uma palavra reservada na linguagem sem precisar declarar.
            }
            if (this.Cargo == "Diretor"){
                _bonificacao += value * 0.08;
            }
        }
    }
}