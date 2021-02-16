using System;

namespace Uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, dentro, fora,num;

            dentro = 0;
            fora = 0;

            n = int.Parse(Console.ReadLine());

            while(n>10000)
            {
                Console.WriteLine("digite novamente");
                n = int.Parse(Console.ReadLine());
            }

            for(c = 1; c<=n;c++)
            {
                num = int.Parse(Console.ReadLine());

                if(num >=10&&num<=20)
                {
                    dentro += +1;
                }
                else
                {
                    fora += +1;
                }
            }


            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");

        }
    }
}
