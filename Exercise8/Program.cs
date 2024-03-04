using System.Transactions;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a max number: ");
            int maxNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < maxNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Enter an amount of asterisks: ");
            int maxAst = int.Parse(Console.ReadLine());

            for (int i = 0; i < maxAst; i++)
            {
            
                
                    Console.Write("*");
                

            }
            //Console.WriteLine(maxNum);
            //asterisk
        }
    }
}