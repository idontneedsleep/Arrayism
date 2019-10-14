using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s1=0, s2=0;
            double s = 0, a, b, c;
            double[] myarr = new double[12];
            for(int i=0;i<myarr.Length;i++)
                myarr[i] = Convert.ToDouble(Console.ReadLine());
            Sumv(ref s, myarr);
            Console.WriteLine($"сумма отрицательных элементов {s}");
            AMax(out a, myarr);
            Console.WriteLine($"максимальный элемент {a}");
            IMax(out n, out b, myarr);
            Console.WriteLine($"индекс максимального элемента {n}");
            AbsMax(out c, myarr);
            Console.WriteLine($"максимальный модуль {c}");
            SumI(ref s1, myarr);
            Console.WriteLine($"сумма индексов положительных элементов {s1}");
            Zc(ref s2, myarr);
            Console.WriteLine($"количество целых элементов {s2}");
        }
        static void Sumv(ref double d, params double[] ahh)
        {
            d = 0;
            for (int i = 0; i < 12; i++)
                if (ahh[i] < 0) d += ahh[i];
        }
        static void AMax(out double m, params double[] ahh)
        {
            m = ahh[0];
            for (int i = 0; i < 12; i++)
            {
                if (m < ahh[i]) m = ahh[i];
            }
        }
        static void IMax(out int b,out double m, params double[] ahh)
        {
            b = 0;
            m = ahh[0];
            for (int i = 0; i < 12; i++)
                if (m < ahh[i])
                {
                    b = i;
                    m = ahh[i];
                }
        }
        static void AbsMax(out double m, params double[] ahh)
        {
            m = Math.Abs(ahh[0]);
            for (int i = 0; i < 12; i++)
                if (m < Math.Abs(ahh[i])) m = Math.Abs(ahh[i]);
        }
        static void SumI(ref int d, params double[] ahh)
        {
            d = 0;
            for (int i = 0; i < 12; i++)
                if (ahh[i] > 0) d += i;
        }
        static void Zc(ref int m, params double[] ahh)
        {
            m = 0;
            for (int i = 0; i < 12; i++)
                if (ahh[i] == (int)ahh[i]) m++;
        }
    }
}
