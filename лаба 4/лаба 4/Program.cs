using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
    
    class Program
    {
        static void Main()
        {
            Set<int> Arr = new Set<int>();
            Set<int> Arr1 = new Set<int>();
            Arr.Add(1);
            Arr.Add(2);
            Arr.Add(3);
            Arr.Add(4);
            Arr.Add(5);
            Arr.Add(6);
            Arr.Add(7);
            Arr.Out();
            Console.WriteLine("\n");
            Arr1.Add(1);
            Arr1.Add(2);
            
            Arr1.Add(4);
            Arr1.Add(5);
            Arr1.Add(6);
            Arr1 -= 5;
            Arr1.Out();

            Set<int> Arr2;

            Arr2 = Arr * Arr1;

            Arr2.Out();

            Arr2 = Arr1 & Arr;

            Arr2.Out();
            string str = "hello";
            str = OperationExpension.AddPoint(str);

            Console.WriteLine(str);
            Console.WriteLine("sum = " + OperationExpension.Sum(Arr, Arr1));

            Console.WriteLine("Сравнение множеств: " + (Arr < Arr1));
            Console.WriteLine("проверка на подмножество: " + (Arr > Arr1));
            int a;

            a = OperationExpension.GetMaxElement(Arr) - OperationExpension.GetMinElement(Arr1);

            Console.WriteLine("разность max и min {0}", a);

            string str1 = ".";
            str1 = str1.DeletePoint();
            Console.WriteLine(str1);

            Console.ReadKey();

           
        }
    }
}
