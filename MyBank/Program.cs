using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clientAna = new Client("Ana", 1234, 100.50);
            clientAna.Conta = 789;

            Client clientClara = new Client("Clara", 1234, 3000);
            clientClara.Conta = 790;

            //clientAna.Saldo += 1000;

            //clientAna.Sacar(70);

            //clientAna.Transfirir(100, clientClara);

            Console.WriteLine("O saldo desta conta é: "+ clientAna.Saldo);
            Console.WriteLine("O número desta conta é: "+ clientAna.Conta);
            Console.WriteLine("O saldo desta conta é: "+ clientClara.Saldo);
            Console.WriteLine("O número desta conta é: "+ clientClara.Conta);

        }
    }
}
