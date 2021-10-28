public class Vendedor:Funcionario{

     public int nClientesAtendidos { get; set; }

     public override double Bonificacao
    {
        get

        {
            return _bonificacao;
        }

        set
        {
            _bonificacao += value * 0.02;
        }
    }
}