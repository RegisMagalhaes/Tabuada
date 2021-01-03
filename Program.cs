using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("-----------Tabuada-----------");
            System.Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine("{0} x {1} = {2}", num, i, (num*i));
            }
        }
    }
}
