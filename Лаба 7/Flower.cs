using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_7
{

    
    class Flower : Plant
    {


        public struct flowerProperties
        {
            public Color color;
            public int price;

            public flowerProperties(Color color, int price)
            {
                this.color = color;
                this.price = price;
            }
        }
        flowerProperties flow = new flowerProperties();
        public Color Color
        {
            get
            {
                return flow.color;
            }
            set
            {
                flow.color = value;
            }
        }
        public int Price
        {
            get
            {
                return flow.price;
            }
            set
            {
                flow.price = value;
            }
        }
        public override string GetInfo()
        {
            string str;

            str = $"вид: {Vid}\nвысота: {Hidth}\nЦвет: {Color}\nвозраст: {Age}\n";

            return str;
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
    class Flow : Flower
    {
        public string pole;
        public Flow()
        {

        }
    }
}
