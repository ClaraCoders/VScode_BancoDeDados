using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
           Client clientAna = new Client("Ana", 1234, 789, 100.50);
           Client clientClara = new Client("Clara", 1234, 790, 3000);

           bool retorno = clientAna.Sacar(50);
           Console.WriteLine(retorno);
           Console.WriteLine("O titular desta conta é: "+ clientAna.titular);
           Console.WriteLine("O titular desta conta é: "+ clientClara.titular);
           

           clientClara.Depositar(3000);
           Console.WriteLine("O saldo da sua conta foi para R$" + clientClara.saldo);

           clientClara.Transfirir(2000, clientAna);
           Console.WriteLine("O saldo da sua conta foi para R$" + clientClara.saldo);
           Console.WriteLine("O saldo da sua conta foi para R$" + clientAna.saldo);
        }
    }
}
