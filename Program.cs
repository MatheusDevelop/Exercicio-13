using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calcular conta = new Calcular();
            int num1,num2;
            Console.WriteLine("Digite um numero para saber seu dobro");
            num1=int.Parse(Console.ReadLine());
            conta.Soma(num1);
            Console.WriteLine("Digite dois numeros para saber sua soma");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            conta.Soma(num1,num2);
            Console.WriteLine("Digite dois numeros para concatenar");
            string n1=Console.ReadLine();
            string n2=Console.ReadLine();
            conta.Soma(n1,n2);




        }
    }
}
