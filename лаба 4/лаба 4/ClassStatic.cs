using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
    static class OperationExpension
    {
        public static string AddPoint(this string d)//метод расширения(добавление точки в конце строки)
        {
            return d +='.';
        }
        public static string DeletePoint(this string d) 
        {
            string str = d;
            for (int i = 0; i<str.Length; i++)
            {
                if (str[i] == '.')
                {
                    
                     str = str.Replace(".", "!");
                }
            }
            return d;
        }
        public static Set<int> RemoveNull(Set<int> list) //удаление нулевых элементов
        {
            list.RemoveEl(0);
            return list;
        }

        public static int Sum(Set<int> list1, Set<int> list2)
        {
            int sum = 0;
            foreach(var item in list1)
            {
                sum += item;            
            }
            foreach(var item in list2)
            {
                sum += item;
            }            
            return sum;
        }

        public static int GetMaxElement(Set<int> set1)
        {
            int maxstr = set1.GetElem(0);
            foreach (var item in set1)
            {
                if (item > maxstr)
                {
                    maxstr = item;
                }
            }
            return maxstr;
        }

        public static int GetMinElement(Set<int> set1)
        {
            int minstr = set1.GetElem(0);
            foreach (var item in set1)
            {
                if (item < minstr)
                {
                    minstr = item;
                }
            }
            return minstr;
        }
    }
}
