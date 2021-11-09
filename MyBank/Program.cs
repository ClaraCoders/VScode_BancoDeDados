using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Gerente gPaulo = new Gerente(){
                Name = "Paulo",
                CPF = "123.123.123-32",
                Salario = 6000,
                nAgencia = 5

            };

            Vendedor Lucas = new Vendedor() {
                Name = "Lucas",
                CPF = "130.130.130-30",
                Salario = 1200,
                nClientesAtendidos = 5
            };
            

            Vendedor Caroline = new Vendedor(){
                Name = "Caroline",
                CPF = "120.120.120-20",
                Salario = 1200,
                nClientesAtendidos = 3
            };
            

            Vendedor Elza = new Vendedor() {
                Name = "Elza",
                CPF = "110.110.110-10",
                Salario = 8000,
                nClientesAtendidos = 7
            };

            

            Lucas.Bonificacao = Lucas.Salario;

            Client clientAna = new Client("Ana Clara Freitas Garcia", 1234, 200, Lucas); //Lucas
            Client clientFernanda = new Client("Fernanda Magalhães", 1234, 500, Caroline); //Caroline
            Client clientWesley = new Client("Wesley Rush", 1234, 3300, Elza); //Elza


            Console.WriteLine("");
            Console.WriteLine("        As contas cadastradas são:");

            Console.WriteLine("");

            Console.WriteLine("O titular desta conta é: "+ clientAna.Titular);
            Console.WriteLine("O saldo desta conta é: R$"+ clientAna.Saldo);
            Console.WriteLine("O vendedor desta cliente é: "+ Lucas.Name);

            Console.WriteLine("");

            Console.WriteLine("O titular desta conta é: "+ clientFernanda.Titular);
            Console.WriteLine("O saldo desta conta é: R$"+ clientFernanda.Saldo);
            Console.WriteLine("O vendedor desta cliente é: "+ Caroline.Name);

            Console.WriteLine("");

            Console.WriteLine("O titular desta conta é: "+ clientWesley.Titular);
            Console.WriteLine("O saldo desta conta é: R$"+ clientWesley.Saldo);
            Console.WriteLine("O vendedor desta cliente é: "+ Elza.Name);

            Console.WriteLine("");
            Console.WriteLine("        Saques Realizados");
            Console.WriteLine("");

            clientAna.Sacar(100);
            Console.WriteLine("Após o saque, o valor na conta de Ana é: R$"+ clientAna.Saldo);
            Console.WriteLine("");

            Console.WriteLine("        Transferências Realizadas");
            Console.WriteLine("");

            clientWesley.Transfirir(200, clientAna);
            Console.WriteLine("Após a transferência, o saldo conta Wesley é: R$"+ clientWesley.Saldo);
            Console.WriteLine("E o saldo na conta de Ana é: R$"+clientAna.Saldo);


            Console.WriteLine("");
            Console.WriteLine("        Depositos Realizados");
            Console.WriteLine("");

            clientFernanda.Depositar(100);
            Console.WriteLine("Após o deposito, o Saldo da conta de Fernanda é: R$" + clientFernanda.Saldo);
            Console.WriteLine("");


            Console.WriteLine("        Saldo disponivel nas contas");
            Console.WriteLine("");
            
            Console.WriteLine("O saldo da conta da Ana é: " + clientAna.Saldo);
            Console.WriteLine("O saldo da conta da Fernanda é: " + clientFernanda.Saldo);
            Console.WriteLine("O saldo da conta do Wesley é: " + clientWesley.Saldo);
            Console.WriteLine("");

            Console.WriteLine("        Comissão vendedores");
            Console.WriteLine("");

            Console.WriteLine("A comissao do vendedor Lucas é: " + Lucas.Comissao);
            Console.WriteLine("A comissao da vendedora Caroline é: " + Caroline.Comissao);
            Console.WriteLine("A comissao da vendedora Elza é: " + Elza.Comissao);
            Console.WriteLine("Total de comissão a ser pago: " + Client.TComissao);
            Console.WriteLine("");

            Console.WriteLine("        Bonificação Anual");
            Console.WriteLine("");

            Console.WriteLine("A bonificação do vendedor Lucas é de: R$" + Lucas.Bonificacao);
            Console.WriteLine("A bonificação da vendedora Caroline é de: R$" + Caroline.Bonificacao);
            Console.WriteLine("A bonificação da vendedora Elza é de: R$" + Elza.Bonificacao);
            Console.WriteLine("A bonificação do gerente Paulo é de: R$" + gPaulo.Bonificacao);
            Console.WriteLine("");

            Console.WriteLine("        Remuneração Total");
            Console.WriteLine("");
            
            Console.WriteLine("O vendedor Lucas receberá R$" + Lucas.RemuneracaoTotal(Lucas.Salario, Lucas.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A vendedora Caroline receberá R$" + Caroline.RemuneracaoTotal(Caroline.Salario, Caroline.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A vendedora Elza receberá R$" + Elza.RemuneracaoTotal(Elza.Salario, Elza.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("O gerente Paulo receberá R$" + gPaulo.RemuneracaoTotal(gPaulo.Salario, gPaulo.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("");

            Console.WriteLine("        Férias");
            Console.WriteLine("");

            Console.WriteLine("O gerente Paulo terá " + gPaulo.CalcularFerias() + " dias de férias");
            Console.WriteLine("O vendedor Lucas terá " + Lucas.CalcularFerias() + " dias de férias");
            Console.WriteLine("A vendedora Caroline terá " + Caroline.CalcularFerias() + " dias de férias");
            Console.WriteLine("A vendedora Elza terá " + Elza.CalcularFerias() + " dias de férias");
            Console.WriteLine("");

            Console.WriteLine("        Total de Contas");

            Console.WriteLine("O total de contas criadas é: " + Client.TotalContas);
        }        
    }
}
