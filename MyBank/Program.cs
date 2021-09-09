using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
           client clientAna = new client("Ana", 1234, 789, 100.50);
           client clientClara = new client("Clara", 1234, 790, 3000);


           Console.WriteLine("O titular desta conta é: "+ clientAna.titular);
           Console.WriteLine("O titular desta conta é: "+ clientClara.titular);
           
        }
    }
}
