using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Лаба_11
{  
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

           

            var select1 = from i in monthes
                          where i.Length == 4
                          select i;
            Console.WriteLine("Месяцы с длинной 4: ");
            foreach (string i in select1)
                Console.WriteLine(i);
            string[] summer_winterMonthes = { "December", "January", "February", "June", "July", "August" };
            var select2 = from i in monthes
                          where monthes.Contains(i)
                          select i;
            Console.WriteLine("Зимние и летние мясяцы: ");
            foreach (string i in select2)
                Console.WriteLine(i);
            Console.WriteLine("месяцы в алфавитном порядке: ");
            var select3 = from i in monthes
                          orderby i
                          select i;
            foreach (string i in select3)
                Console.WriteLine(i);
            Console.WriteLine("месяцы имеющие букву 'u' и длиннее 4-х: ");
            var select4 = from i in monthes
                          where i.Contains("u") && i.Length >= 4
                          select i;
            foreach (string i in select4)
                Console.WriteLine(i);
            ///////////////////////////ZD2

            List<Customer> customers = new List<Customer>
            {
                new Customer(1, "Jon", 1234),
                new Customer(1, "Jake", 12345),
                new Customer(3, "Pitr", 123456),
                new Customer(4, "Mark", 1234567),
                new Customer(1, "Kevin", 12345678),
                new Customer(6, "Bill", 123456789),
                new Customer(1, "Boss", 1234567890),
                new Customer(8, "Kirill", 234567890),
            };

            List<Customer> cust1 = (from i in customers
                                   orderby i
                                   select i).ToList();
           
            foreach (var i in cust1)
                Console.WriteLine("CUST1: " + i.Name);
            List<Customer> cust2 = (from i in customers
                                    where i.NumCurd >= 123456 && i.NumCurd <= 123456789
                                    select i).ToList();

            int maxNumCurd = (from t in customers select t.NumCurd).Max();

            List<Customer> cust4_1 = (from i in customers
                                      where i.Name == "jon"
                                      select i).ToList();

            var names = customers.Select(u => u.Name);

            List<Customer> cust4_3 = (from i in customers
                                    orderby i.Name descending
                                      select i).ToList();

            var SortedByGroup = from t in customers group t by t.id;

            byte[] MaxId = customers.Max(i => i.id);
            Console.WriteLine(MaxId);
            
            //кванторы с blog.rc     
            int[] numbers = { 10, 9, 8, 7, 6 };
            bool hasTheNumberNine = numbers.Contains(9); // true
            bool hasMoreThanZeroElements = numbers.Any(); // true
            bool hasOddNum = numbers.Any(k => k % 2 == 1); // true
            bool allOddNums = numbers.All(k => k % 2 == 1); // false


            var result = from i in summer_winterMonthes
                         join m in monthes on i equals m
                         select new {i};

            foreach (var i in result)
                Console.WriteLine("месяцы с join: " + i);
            Console.ReadKey();
        }
    }
}
