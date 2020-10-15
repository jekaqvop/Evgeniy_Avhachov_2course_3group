using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
    public class Set<T>
    {
        private List<T> elements = new List<T>();

        public T GetElem(int i)
        {
            return elements[i];
        }

        public void RemoveEl(T item) //удаление элемента
        {
            elements.Remove(item);
        }
        public void Add(T item) //добавление элемента
        {
            if (!elements.Contains(item))
            {
                elements.Add(item);
            }
        }
        public IEnumerator<T> GetEnumerator()   //перебор элементов
        {
            return elements.GetEnumerator();
        }
        public int Count => elements.Count(); //записывает в Count количество элементов
        public static Set<T> Intersection(Set<T> obj1, Set<T> obj2) //пересечение
        {
            var resultSet = new Set<T>();

            if (obj1.Count < obj2.Count)
            {
                foreach (var item in obj1.elements)
                {
                    if (obj2.elements.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in obj2.elements)
                {
                    if (obj1.elements.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            return resultSet;
        }

        public static bool Check(Set<T> obj1, Set<T> obj2) //Проверка на подмножество
        {

            byte schet = 0;

            foreach (var item in obj1.elements)
            {
                if (obj2.elements.Contains(item))
                {
                    schet++;
                }
            }

            if (schet == obj2.Count)
                return true;
            else
                return false;
        }
        public static bool Comparison(Set<T> obj1, Set<T> obj2) //сравнение
        {
            bool check = false;
            if (obj1.Count == obj2.Count)
            {
                foreach (var item in obj1.elements)
                {
                    if (obj2.elements.Contains(item))
                    {
                        check = true;
                    }
                    else
                        check = false;
                }
            }
            return check;
        }
        public static Set<T> Union(Set<T> obj1, Set<T> obj2)//объединение
        {
            var resultSet = new Set<T>();

            var items = new List<T>();
            if (obj1.elements != null && obj1.elements.Count > 0)
            {
                items.AddRange(new List<T>(obj1.elements));
            }
            if (obj2.elements != null && obj2.elements.Count > 0)
            {
                items.AddRange(new List<T>(obj2.elements));
            }
            resultSet.elements = items.Distinct().ToList();
            return resultSet;
        }
        public void Out()       //вывод массива
        {
            foreach (T str in this.elements)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }

        public static Set<T> operator -(Set<T> list, T item)    //удаление элемента
        {
            list.RemoveEl(item);
            return list;
        }

        public static Set<T> operator *(Set<T> list1, Set<T> list2)     //пересечение множеств
        {
            return Intersection(list1, list2);
        }

        public static Set<T> operator &(Set<T> list1, Set<T> list2) //объединение множеств
        {
            return Union(list1, list2);
        }

        public static bool operator <(Set<T> list1, Set<T> list2) //сравнение множеств
        {
            return Comparison(list1, list2);
        }
        public static bool operator >(Set<T> list1, Set<T> list2) //проверка на подмножество
            {
                return Check(list1, list2);
            }

        public class Owner
        {
            int id;
            string name;
            string organiz;
            public Owner(int id, string name, string organiz)
            {
                this.id = id;
                this.name = name;
                this.organiz = organiz;
            }
        }
        public readonly Owner owner = new Owner(3, "Jeka Avhachev", "organiz");

        public class Date
        {
            DateTime date = DateTime.Today;

            public override String ToString()
            {
                return date.ToShortDateString();
            }
        }

        public readonly Date date = new Date(); 
    }


}
