using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario Lucas = new Funcionario();
            Lucas.Name = "Lucas";
            Lucas.CPF = "130.130.130-30";
            Lucas.Cargo = "Secretário";
            Lucas.Salario = 1200;

            Funcionario Caroline = new Funcionario();
            Caroline.Name = "Caroline";
            Caroline.CPF = "120.120.120-20";
            Caroline.Cargo = "Administradora";
            Caroline.Salario = 3000;

            Funcionario Elza = new Funcionario();
            Elza.Name = "Elza";
            Elza.CPF = "110.110.110-10";
            Elza.Cargo = "Administradora";
            Elza.Salario = 4000;


            Client clientAna = new Client("Ana", 1234, 100.50, Lucas);
            clientAna.Conta = 789;
            Client clientClara = new Client("Clara", 1234, 3000, Caroline);
            clientClara.Conta = 790;
            Client clientIsabelle = new Client ("Isabelle", 1234, 5000, Elza);
            clientIsabelle.Conta = 791;

            //clientAna.Saldo += 1000;

            clientIsabelle.Sacar(70);
            clientAna.Transfirir(100, clientClara);
            clientClara.Depositar(200);

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

        }
    }
}
