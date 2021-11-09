public class Gerente : Funcionario{

    public int nAgencia { get; set; }
    
    public override double Bonificacao
    {
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += value * 0.08;
        }
    }
    public override int CalcularFerias()
    {
        var dias_ferias = 30 + nAgencia * 5;
        return dias_ferias;
    }
}