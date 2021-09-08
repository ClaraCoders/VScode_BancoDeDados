using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
           client clientAna = new client();

           clientAna.titular = "Ana";
           clientAna.agencia = 1234;
           clientAna.conta = 789;
           clientAna.saldo = 100.50;

           client clientClara = new client();

           clientClara.titular = "Clara";
           clientClara.agencia = 1234;
           clientClara.conta = 790;
           clientClara.saldo = 3000;

           Console.WriteLine("O titular desta conta é: "+ clientAna.titular);
           Console.WriteLine("O titular desta conta é: "+ clientClara.titular);
        }
    }
}
