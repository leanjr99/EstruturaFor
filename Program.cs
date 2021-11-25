using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */

            string[] nome = new string[5];

            nome[0] = "Rosa";
            nome[1] = "Ricardo";
            nome[2] = "Marcos";
            nome[3] = "João";
            nome[4] = "Maria";

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}
