using System;
using System.Net.WebSockets;

class Yasmamoto
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digit outro numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num + num2;

        Console.WriteLine($"As somas dos numeros é igual a {result}");

        if(num2 > num)
        {
            Console.WriteLine($"O numero {num2} é maior");
        }

        Console.ReadKey();
    }
}
