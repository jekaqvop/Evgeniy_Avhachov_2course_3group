using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_9
{
    static class ChangeString
    {
        
        public static string DeletePunctSigns(string str)
        {
            StringBuilder rc = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
                if (str[i] != ',' && str[i] != '.' && str[i] != '!' && str[i] != ':' && str[i] != ';')
                    rc.Append(str[i], 1);

           Console.WriteLine($"Строка без знаков пунктуации: {rc}");
           return rc.ToString();
        }

        public static string ToUpperCase(string str)
        {
            Console.WriteLine($"Строка в верхнем регистре: {str.ToUpper()}");
            return str.ToUpper();
        }

        public static string DeleteUnnecessarySpace(string str)
        {
            StringBuilder rc = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                {
                    rc.Append(str[i], 1);
                    while (str[i + 1] == ' ')
                        i++;
                }
                else
                    rc.Append(str[i], 1);
            Console.WriteLine($"Строка без лишних пробелов: {rc}");
            return rc.ToString();
        }

        ////////////////////////////////////
        //for Action

        public static void AddSymbols(string str, string additionSymbols)
        {
            str = str.Insert(0, additionSymbols);
            str += additionSymbols;
            /////////////////////////////////
            Console.WriteLine($"Рузультат: {str}");
        }
    }
}
