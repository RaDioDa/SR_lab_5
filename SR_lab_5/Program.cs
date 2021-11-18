using System;

namespace SR_lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fail1 = 2;
            int fail2 = 86;
            int work = 3 * 3600;
            int m = (fail1 + fail2) / 2;
            double tt = 0;
            double t = 0;
            double k = 0.005;

            for(int i = 0; t < work; i++)
            {
                t = (1 / (k * m)) * Math.Exp(i / (m * (k * m)));
                tt += t;
            }

            Console.WriteLine(tt/3600);
        }
    }
}
