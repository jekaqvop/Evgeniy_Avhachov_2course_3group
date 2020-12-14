﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_7
{
    class Cactus : Plant
    {
        Flower flower;
        int width;
        bool flowerbl = false;

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public Cactus()
        {

        }

        public Cactus(int width, bool flowerCheck, DateTime age = new DateTime())
        {
            if (flowerCheck)
                flower = new Flower();
            Age = age;
            this.Width = width;
            this.Age = age;
        }
        
        public void Color(Color color)
        {
            flower.Color = color;
        }
        string GetInfo()
        {
            string str;

            str = $"вид: {Vid}\nвысота: {Hidth}\nЦвет: {flower.ToString()}\n";

            return str;
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
