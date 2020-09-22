using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_kpiyap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите два значения");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            double ans;
            
                ans = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);
                Console.WriteLine("Ответ: " + ans);
            
            if (ans>10)
                Console.WriteLine("многа чем 10");
            
           
            
           

            //

            double a1, a2, b1, b2, c1, c2;
            Console.WriteLine("Введите значения");
            a1 = Convert.ToDouble(Console.ReadLine());
            a2 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());
            c1 = Convert.ToDouble(Console.ReadLine());
            c2 = Convert.ToDouble(Console.ReadLine());

            double ans1;
            ans1 = Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2) + Math.Pow((c1 - c2), 2));
            Console.WriteLine("площадь = "+ans1);

            double ans2, s1, s2 ,s3;
            s1 = Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2));
            s2 = Math.Sqrt(Math.Pow((b1 - b2), 2) + Math.Pow((c1 - c2), 2));
            s3 = Math.Sqrt(Math.Pow((c1 - c2), 2) + Math.Pow((a1 - a2), 2));
            ans2 = s1 + s2 + s3;
            Console.WriteLine("периметр = " + ans2);

            Console.ReadLine();
        }
    }
}
