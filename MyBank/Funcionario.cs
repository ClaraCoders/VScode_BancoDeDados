public abstract class Funcionario {
    
    public string Name { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }
    protected double _bonificacao; 

    public virtual double Bonificacao { 
        get{
            return _bonificacao;
        }

        set{
                _bonificacao += value * 0.01;
            
        }
    }
    
}