using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_7
{
    enum Vid
    {
        oak, birch, chestnut, spruce, pine

    }

    class Paper : Plant
    {
        Vid vidPaper;

        Color color;

        public Color Color
        {
            get => color;
            set
            {
                color = value;
            }
        }
        public Vid VidPaper
        {
            get { return vidPaper; }
            set { vidPaper = value; }
        }
        public Paper(Vid vidPaper)
        {
            VidPaper = vidPaper;
        }
        public Paper()
        {

        }
        public override string ToString()
        {
            return GetInfo();
        }
        public override string GetInfo()
        {
            string str;

            str = $"вид растения: {Vid}\nвид бумаги: {VidPaper}\nвысота: {Hidth}\nЦвет: {Color}\nвозраст растения: {Age}\n";

            return str;
        }
    }
}
