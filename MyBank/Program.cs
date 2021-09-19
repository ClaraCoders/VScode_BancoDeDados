using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clientAna = new Client("Ana", 1234, 789, 100.50);
            Client clientClara = new Client("Clara", 1234, 790, 3000);

            clientAna.Sacar(50);
            Console.WriteLine("O titular desta conta é: "+ clientAna.saldo);

        }
    }
}
