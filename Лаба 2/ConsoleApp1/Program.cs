using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void zd5()
            {
                string str = "hello world";
                int[] array = new int[5];
                for (int i = 0; i < array.Length; i++)
                    array[i] = i;
                (int, int, char) myFunction(int[] arrayOfInt, string string1)
                {
                    (int, int, char) tuple3 = (arrayOfInt.Min(), arrayOfInt.Max(), string1.First());

                    return tuple3;
                }

                Console.WriteLine(myFunction(array, str));
            }
            int num_switch = 0;
            do
            {
                Console.WriteLine("Выбирете номер задания: 1: zd1_ab(); 2: zd1_c(); 3:zd1_df(); 4: zd1_e(); 5:zd2_a(); 6:zd2_b(); 7: zd2_c(); 8:zd2_d(); 9:zd3_a(); 10: zd3_b(); 11: zd3_c(); 12: zd3_d(); 13: zd4(); 14: zd5(); 15: zd6(); ");
                num_switch = Convert.ToInt32(Console.ReadLine());
                switch (num_switch)
                {
                    case 1: 
                        zd1_ab();
                        break;

                    case 2:
                        zd1_c();
                        break;

                    case 3:
                        zd1_df();
                        break;
                    case 4: 
                        zd1_e();
                        break;

                    case 5:
                        zd2_a();
                        break;

                    case 6:
                        zd2_b();
                        break;
                    case 7:
                        zd2_c();
                        break;
                    case 8:
                        zd2_d();
                        break;
                    case 9:
                        zd3_a();
                        break;
                    case 10: 
                        zd3_b();
                        break;

                    case 11:
                        zd3_c();
                        break;
                    case 12: 
                        zd3_d();
                        break;
                    case 13: zd4();
                        break;
                    case 14: zd5();
                        break;
                    case 15: zd6();
                        break;
                }
            } while (num_switch != 0);
            
        }
        static void zd1_ab()
        {
            bool check = false;

            byte b = 0;
            sbyte sb = 0;
            char ch = 'N';
            decimal dec = 0.6m;
            double dob = 0.7;
            float fl = 0.8f;
            int i = 9;
            uint ui = 10;
            long lg = 11;
            ulong ulg = 12;
            short sh = 13;
            ushort ush = 1;
            //неявное
            dob = fl;
            fl = i;
            lg = sh;
            ulg = ush;
            i = sh;
            i = ush;

            //явное
            dob = (float)fl;
            fl = (int)i;
            lg = (short)sh;
            ulg = (ushort)ush;
            i = (short)sh;
            i = (ushort)ush;
            
            Console.WriteLine("bool = "+ check);
            Console.WriteLine($"byte = {b}");
            Console.WriteLine($"sbyte = {sb}");
            Console.WriteLine($"char = {ch}");
            Console.WriteLine($"decimal = {dec}");
            Console.WriteLine($"double = {dob}");
            Console.WriteLine($"float = {fl}");
            Console.WriteLine($"int = {i}");
            Console.WriteLine($"uint = {ui}");
            Console.WriteLine($"long = {lg}");
            Console.WriteLine($"ulong = {ulg}");
            Console.WriteLine($"short = {sh}");
            Console.WriteLine($"ushort = {ush}");

            Console.WriteLine("Please, input type bool: ");
            check = Convert.ToBoolean(Console.ReadLine()[0]-48);
            Console.WriteLine("Please, input type byte: ");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please, input type byte: ");
            sb = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Please, input type Char: ");

            ch = (char)Console.ReadLine()[0];
            Console.WriteLine("Please, input type Demical: ");
            dec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Please, input type double: ");
            dob = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Please, input type float: ");
            fl = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Please, input type int: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please, input type uint: ");
            ui = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Please, input type long: ");
            lg = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Please, input type ulong: ");
            ulg = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"Please, input type short: ");
            sh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Please, input type ushort: ");
            ush = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine($"bool = {check}");
            Console.WriteLine($"byte = {b}");
            Console.WriteLine($"sbyte = {sb}");
            Console.WriteLine($"char = {ch}");
            Console.WriteLine($"decimal = {dec}");
            Console.WriteLine($"double = {dob}");
            Console.WriteLine($"float = {fl}");
            Console.WriteLine($"int = {i}");
            Console.WriteLine($"uint = {ui}");
            Console.WriteLine($"long = {lg}");
            Console.WriteLine($"ulong = {ulg}");
            Console.WriteLine($"short = {sh}");
            Console.WriteLine($"ushort = {ush}");
        }
        static void zd1_c()
        {

            int i = 0;
            object oi = i;
            i = (int)oi;

      

            byte b = 0;
            object ob = b;
            b = (byte)ob;

            sbyte sb = 0;
            object osb = sb;
            sb = (sbyte)osb;

            short sh = 0;
            object osh = sh;
            sh = (short)osh;

            ushort ush = 0;
            object oush = ush;
            ush = (ushort)oush;

            long lg = 0;
            object olg = lg;
            lg = (long)olg;

            ulong ulg = 0;
            object oulg = ulg;
            ulg = (ulong)oulg;

            float fl = 0;
            object ofl = fl;
            fl = (float)ofl;

            double db = 0;
            object odb = db;
            db = (double)odb;

            bool bl = true;
            object obl = bl;
            bl = (bool)obl;

            char ch = 'H';
            object och = ch;
            ch = (char)och;
        }
            struct one_struct
            { 

            }
        static void zd1_df()
        {
            var a = new[] { 0, 1, 2 };
            for(var i = 0; i< a.Length; i++)
                Console.WriteLine($"mas= {a[i]}");
        }

        static void zd1_e()
        {
            int? nullable_value = null;
            Console.WriteLine("Имеет ли значение и если имеет то какое: " + nullable_value.HasValue.ToString() + ' ' + nullable_value);
            short? nullable2_value = 5;
            Console.WriteLine("Имеет ли значение и если имеет то какое: " + nullable2_value.HasValue.ToString() + ' ' + nullable2_value);
        }
        static void zd2_a()
        {
            string str1 = "hello1", str2 = "hello2";
            Console.WriteLine($"str1 = {str1}");
            Console.WriteLine($"str2 = {str2}");
            Console.WriteLine("Результат сравнение строк str1 и str2 " + str1.CompareTo(str2));
        }
        static void zd2_b()
        {
            string str1 = "ab", str2 = "abc", str3 = "abcd";
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
            Console.WriteLine("str3: " + str3);
            Console.WriteLine("Объединение str1 с str3: " + String.Concat(str1, str3));
            Console.WriteLine("Вставка копии str1 в строку str2: " + str2.Insert(1, String.Copy(str1)));
            Console.WriteLine("Подстрока str3 начиная с позиции 2: " + str3.Substring(2));
            string str4 = "ab cd ef";
            Console.WriteLine("str4: " + str4);
            Console.WriteLine("Массив строк с разбитыми пробелом подстроками строки str4: ");
            string[] strs = str4.Split(new char[] { ' ' });
            for (var i = 0; i < strs.Length; i++)
                Console.WriteLine(strs[i]);
            Console.WriteLine("Введите индекс для вставки подстроки str2 \"bc\" в str1: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(str1.Insert(index, str2.Substring(1)));
            Console.WriteLine("Введите подстроку str3 = \"abcd\" для её удаления ");
            string substr = Console.ReadLine();
            Console.WriteLine(str3.Replace(substr, ""));
        }

        static void zd2_c()
        {
            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));

            String Test(string s)
            {
                if (String.IsNullOrEmpty(s))
                    return "is null or empty";
                else
                    return String.Format("(\"{0}\") is neither null nor empty", s);
            }
        }
        static void zd2_d()
        {
            StringBuilder str7 = new StringBuilder("Hello World!");
            Console.WriteLine("Строка str7 (создана при помощи StringBuilder): " + str7);
            str7.Remove(5, 1);
            str7.Remove(10, 1);
            Console.WriteLine("Строка str7 после удаления 6 и 11 символов: " + str7.ToString());
            str7.Insert(0, "--");
            str7.Insert(str7.Length, "--");
            Console.WriteLine("Строка str7 после вставки \"--\" в начале и конце: " + str7.ToString());
        }
        static void zd3_a()
        {
            int[][] arr = new int[5][];
            for(int i = 0; i < 5; i++)
            {
                arr[i] = new int[5];
            }
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr[i][j] = rand.Next(10, 99);
                    Console.Write($" {arr[i][j]}");
                }
                Console.Write("\n");
            }
        }

        static void zd3_b()
        {
            string[] str_mas = { "a", "ab", "abc", "abcd", "abcde" }; // одномерный массив
            Console.WriteLine("Одномерный массив строк: ");
            for (var i = 0; i < str_mas.Length; i++)
                Console.Write(str_mas[i] + ' ');
            Console.WriteLine();
            Console.WriteLine("Длинна массива: " + str_mas.Length.ToString());
            Console.WriteLine("Номер элемента который хотите изменить: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Строка для замены: ");
            str_mas[id - 1] = Console.ReadLine();
            Console.WriteLine("Результат:");
            for (var i = 0; i < str_mas.Length; i++)
                Console.Write(str_mas[i] + ' ');
            Console.Write('\n');
        }
        static void zd3_c()
        {
            int[][] mas1 = new int[3][];
            mas1[0] = new int[2];
            mas1[1] = new int[3];
            mas1[2] = new int[4];
            Console.WriteLine("Введите элементы ступенчатого массива (9 чисел): ");
            for (var i = 0; i < mas1.Length; i++)
                for (var j = 0; j < mas1[i].Length; j++)
                    mas1[i][j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат: ");
            for (var i = 0; i < mas1.Length; i++)
            {
                for (var j = 0; j < mas1[i].Length; j++)
                    Console.Write(mas1[i][j].ToString() + ' ');
                Console.Write('\n');
            }
        }   
        static void zd3_d()
        {
            // d.Создайте неявно типизированные переменные для хранения массива и строки
            string str = "hello world";
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            var Array = array;
            var String = str;

        }
        static void zd4()
        {
            (int, string, char, string, ulong) tuple = (a: 4, b: "jeka", c: 'a', d: "string", e: 56);
            // c.Выведите кортеж на консоль целиком и выборочно(1, 3, 4  элементы)
            Console.WriteLine("{0} {1} {2} {3} {4}", tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
            Console.WriteLine("{0} {1} {2}", tuple.Item1, tuple.Item3, tuple.Item4);
            // d.Выполните распаковку кортежа в переменные
            (var a, var b, var v, var d, var e) = (tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
            // e.Сравните два кортежа.
            (int, string, char, string, ulong) tuple2 = (a: 4, b: "jeka", c: 'a', d: "string", e: 56);

            if (tuple.Equals(tuple2))
            {
                Console.WriteLine("Кортежи равны!");
            }
            else
                Console.Write("Кортежи не равны!");
        }
        static void zd6()
        {
            int ten = 10;
            void fun1()
            {
                
                checked
                {
                    int i3 = 2147483647;
                    Console.WriteLine(i3);
                }
            }
            void fun2()
            {
                unchecked
                {
                    int i3 = 2147483647;
                    Console.WriteLine(i3);
                }
            }
            fun1();
            fun2();
        }
    }
}
