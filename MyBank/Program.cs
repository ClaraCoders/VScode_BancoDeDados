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
                Salario = 6000

            };

            Vendedor Lucas = new Vendedor() {
                Name = "Lucas",
                CPF = "130.130.130-30",
                Salario = 1200
            };
            

            Vendedor Caroline = new Vendedor(){
                Name = "Caroline",
                CPF = "120.120.120-20",
                Salario = 1200
            };
            

            Gerente Elza = new Gerente() {
                Name = "Elza",
                CPF = "110.110.110-10",
                Salario = 8000
            };

            

            Lucas.Bonificacao = Lucas.Salario;

            Client clientAna = new Client("Ana", 1234, 100.50, Lucas);
            clientAna.Conta = 789;
            Client clientClara = new Client("Clara", 1234, 3000, Caroline);
            clientClara.Conta = 790;
            Client clientIsabelle = new Client ("Isabelle", 1234, 5000, Elza);
            clientIsabelle.Conta = 791;

            //clientAna.Saldo += 1000;

            clientIsabelle.Sacar(70);
            clientAna.Depositar(200);
            clientClara.Transfirir(100, clientAna);

            Console.WriteLine("O saldo de Ana é: "+ clientAna.Saldo);
            Console.WriteLine("O número da agencia da conta de Ana é: "+ clientAna.Conta);
            Console.WriteLine("O saldo de Clara é: "+ clientClara.Saldo);
            Console.WriteLine("O número da agencia da conta de Clara é: "+ clientClara.Conta);
            Console.WriteLine("O saldo de Isabelle é: "+ clientIsabelle.Saldo);
            Console.WriteLine("O número da agencia da conta de Isabelle é: "+ clientIsabelle.Conta);
        
            Console.WriteLine("O número total de contas é: "+ Client.TotalContas);
            Console.WriteLine("O número total de comissao é: "+ Client.Comissao);
            Console.WriteLine("O salario do Lucas é de: " + Lucas.Salario);
            Console.WriteLine("O salario do Caroline é de: " + Caroline.Salario);
            Console.WriteLine("O salario do Elza é de: " + Elza.Salario);
            Console.WriteLine("Salário do gerente Paulo é: RS" + gPaulo.Salario);

        }
    }
}
