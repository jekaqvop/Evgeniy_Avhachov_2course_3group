﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_9
{
    class Student
    {
        int zp = 500;
        string name;
        public string Name { get => name; set { name = value; } }
        public Student(string name)
        {
            Name = name;
        }

        public int Zp
        {
            get => zp;
            set
            {
                zp = value;
            }
        }

        public void AddZp(int add)  
        {
            Console.WriteLine("премия " + Name); 
            Zp += add;
        }

        public void Minus()
        {
            Console.WriteLine("Штраф " + Name);
            Zp -= 100;
        }

        
    }
}
