using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- jogo do alimento ---");

        Console.Write("qtos alimentos vai ter? ");
        int total = Convert.ToInt32(Console.ReadLine());

        if (total <= 0)
        {
            return;
        }

        int rest = total;
        int eu = 0;
        int ele = 0;
        int v = 0;
        int m;

        Console.WriteLine();

        while (rest > 0)
        {
            v = v + 1;
            ele = ele + 1;
            rest = rest - 1;
            Console.Write(ele + " pra vc. ");

            m = 0;
            while (rest > 0 && m < v)
            {
                m = m + 1;
                eu = eu + 1;
                rest = rest - 1;
                Console.Write(m);

                if (rest > 0 && m < v)
                {
                    Console.Write(",");
                }

                Console.Write(" ");
            }

            if (m > 0)
            {
                Console.WriteLine("pra mim");
            }
        }

        Console.WriteLine();
        Console.WriteLine("vc pegou " + ele + " alimento");
        Console.WriteLine("eu peguei " + eu + " alimento");

        Console.ReadLine();
    }
}
