using System;

namespace Tasks
{
    internal class Tasks
    {
        static void Main(string[] args)
        {
            //oppg 1
            int a = 10;
            Console.WriteLine(a);

            //oppg 2
            double x = 5.5;
            double y = 3.3;
            double sum = x + y;
            Console.WriteLine(sum);

            //oppg 3
            if (a > 0)
                Console.WriteLine("større enn 0");
            else if (a < 0)
                Console.WriteLine("mindre enn 0");
            else
                Console.WriteLine("er 0");

            //oppg 4
            double v = 2001;
            if ((v % 4 == 0 && v % 100 != 0) || (v % 400 == 0)) Console.WriteLine(v + " er et skuddår");
            else
            {
                Console.WriteLine(v + " er ikke et skuddår");
            }

            //oppg 5
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //oppg 6
            int u = 0;
            int u2 = 1;
            while (u2 <= 100)
            {
                u += u2;
                u2++;
            }
            Console.WriteLine("Summen er: " + u);

            //oppg 7
            int[] heltall = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < heltall.Length; i++)
            {
                Console.WriteLine(heltall[i]);
            }

            //oppg 8
            int[] heltall2 = { 1, 2, 3, 4, 5 };
            int størst = heltall2[0];
            for (int i = 1; i < heltall2.Length; i++)
            {
            if (heltall2[i] > størst)
                { størst = heltall2[i]; }
            }
            Console.WriteLine("det største tallet er: " + størst);

            //oppg 9
            int[] heltall3 = new int[10];
            int sum2 = 0;
            for (int i = 0; i < 10; i++)
            {
                heltall3[i] = i + 1;
                sum2 += heltall3[i];
            }
            Console.WriteLine("summen av arrayet er: "+ sum2);

            //oppg 10
            Random random = new Random();
            int[] heltall4 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                heltall4[i] = random.Next(1,101);
                if (heltall4[i] % 2 == 0)
                {
                    Console.WriteLine(heltall4[i]);
                }
            }

            //oppg 11
            Console.WriteLine("what timestable do you want? ");
            string number2 = Console.ReadLine();
            int result = int.Parse(number2);
            Console.WriteLine("Here is your timestable");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(result * i);
            }

            //oppg 12
            Console.WriteLine("gjennomsnitt fra 10 random tall");
            double sum3 = 0;
            double[] heltall5 = new double[10];
            for (int i = 0; i < 10; i++)
            {
                heltall5[i] = random.Next(1, 101);
                sum3 += heltall5[i];
            }
            Console.WriteLine(sum3 / 10);
        }
    }
}