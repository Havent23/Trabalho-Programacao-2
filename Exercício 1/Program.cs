using System;

namespace Calculadora
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;
            string op;
            Console.Write("Insira o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o operador: ");
            op = Console.ReadLine();
            if (op == "+"){
                result = num1 + num2;
            } else if (op == "-"){
                result = num1 - num2;
            } else if (op == "*"){
                result = num1 * num2;
            } else {
                result = num1 / num2;
            }
            Console.WriteLine(result);
        }
    }
}