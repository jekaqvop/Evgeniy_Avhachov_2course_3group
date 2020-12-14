using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_13
{
    class Program
    {
        static void Main(string[] args)
        {

            AESDiskInfo.HardsSpace();
            Console.WriteLine("----------------------");
            Console.WriteLine(AESDirInfo.GetDirInfo(@"D:\Учёба 2 курс 1 сем\ООП\ООП\лаба 13"));
            Console.WriteLine("----------------------");
            Console.WriteLine(AESFileManager.ReadListFilesAndDirs("D"));
            AESFileManager.CreateDirAndFile();
            AESFileManager.CopyDir("AESInspect", ".txt");

            Console.WriteLine(AESLog.SearchMethod("HardSpace"));
            Console.WriteLine(AESLog.SearchDate("чт.10.12.2020 12:54:52"));
            Console.WriteLine();
            Console.WriteLine(AESLog.SearchTime("10.12.2020 13:54:52", "10.12.2020 15:54:52"));
            Console.ReadKey();
        }
    }
}
