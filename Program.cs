using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b, c;
            double s1 = 0;
            double s2 = 0, s3 = 1;
            double s = 1, a, a2;
            double[] myarr = new double[12];
            for (int i = 0; i < myarr.Length; i++)
                myarr[i] = Convert.ToDouble(Console.ReadLine());
            AMin(out a,out n, ref s, myarr);
            Console.WriteLine($"добуток элементов после минимального {s}");
            SumN(out c, out b, ref s1, myarr);
            Console.WriteLine($"сумма элементов между первым - и вторым + элементами {s1}");
            NullM(out c, out b, ref s2, myarr);
            Console.WriteLine($"сумма элементов между первым и вторым нулевыми {s2}");
            DobM(out a, out a2, out c, out b, ref s3, myarr);
            Console.WriteLine($"добуток элементов между макс модулем и мин модулем {s3}");
        }
        static void AMin(out double m, out int k, ref double s, params double[] ahh)
        {
            m = ahh[0];
            s = 1;
            k = 0;
            for (int i = 0; i < 12; i++)
                if (m > ahh[i])
                {
                    m = ahh[i];
                    k = i;
                }
            if (k == 11) return;
            else
            for (int i = (k + 1); i < 12; i++)
                s *= ahh[i];
        }
        static void SumN(out int k2, out int k, ref double s, params double[] ahh)
        {
            s = 0;
            k = 0;
            k2 = 0;
            for (int i = 0; i < 12; i++)
                if (ahh[i]<0)
                {
                    k = i;
                    break;
                }
            for (int i = 0; i < 12; i++)
                if (ahh[i] > 0)
                {
                    k2 = i;
                    break;
                }
                for (int i = (k2+1); i < 12; i++)
                if (ahh[i] > 0)
                {
                    k2 = i;
                    break;
                }
            if ((k == k2) || (k2 > k)) return;
            else
            for (int i = (k+1); i < k2; i++)
                    s += ahh[i];
        }
        static void NullM(out int k2, out int k, ref double s, params double[] ahh)
        {
            s = 0;
            k = 0;
            k2 = 0;
            for (int i = 0; i <= 11; i++)
                if (ahh[i] == 0)
                {
                    k = i;
                    break;
                }
            for (int i = 11; i > k; i--)
                    if (ahh[i] == 0)
                    {
                        k2 = i;
                        break;
                    }
            if (k >= k2) return;
            else
                for (int i = (k + 1); i < k2; i++)
                    s += ahh[i];
        }
        static void DobM(out double m, out double m2, out int k2, out int k, ref double s, params double[] ahh)
        {
            s = 1;
            m = Math.Abs(ahh[0]);
            m2 = Math.Abs(ahh[0]);
            k = 0;
            k2 = 0;
            for (int i = 0; i < 12; i++)
                if (m < Math.Abs(ahh[i]))
                {
                    m = Math.Abs(ahh[i]);
                    k = i;
                }
               for (int i = 0; i < 12; i++)
                    if (m2 > Math.Abs(ahh[i]))
                    {
                        m2 = Math.Abs(ahh[i]);
                        k2 = i;
                    }
                    else return;
            if ((k == k2) || (k2 > k)) return;
            else
                for (int i = (k + 1); i < k2; i++)
                    s *= ahh[i];
        }
    }
}
