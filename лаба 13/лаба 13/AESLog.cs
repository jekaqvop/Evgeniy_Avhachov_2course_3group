using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_13
{
    class AESLog
    {
        public static void Writer(string MethodName, string path = "none", string nameFile = "none")
        {
            using (StreamWriter write = new StreamWriter("AESLog.txt", true))
            {
                write.WriteLine($"Method: {MethodName} Path: {path.Replace(" ", "_")} File: {nameFile.Replace(" ", "_")} Called: {DateTime.Now}");
                write.Close();
            }
        }
        public static string SearchMethod(string method)
        {
            string line = "none",
                      line2 = "";
            using (StreamReader reader = new StreamReader("AESLog.txt"))
            {
              
                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(' ');

                    if (splitLine[1] == method)
                    {
                       
                        line2 += line + "\n";
                    }
                    
                }
                reader.Close();
                if (line2 == "")
                    line2 = "none";
                return line2;
            }
        }
        public static string SearchDate(string time)
        {
            string line = "none",
                      line2 = "";
            using (StreamReader reader = new StreamReader("AESLog.txt"))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(' ');
                    try
                    {
                        if (splitLine[7] + " " + splitLine[8] == time || splitLine[7] == time)
                        {                           
                            
                            line2 += line + "\n";                           

                        }
                    }
                    catch(Exception e)
                    {
                   
                        Console.WriteLine("Ошибка:" + e.Message);
                    }

                }
                reader.Close();
                if (line2 == "")
                    line2 = "none\n";
                return line2 + "\n";
            }
        }
        public static string SearchTime(string timefirst, string timelast)
        {
            string line = "none";
            string line2 = "";
            using (StreamReader reader = new StreamReader("AESLog.txt"))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(' ');
                    try
                    {
                        splitLine[7].Remove(0, 3);
                        if (((Convert.ToDateTime(splitLine[7] + " " + splitLine[8]) >= Convert.ToDateTime(timefirst)) 
                            && (Convert.ToDateTime(splitLine[7] + " " + splitLine[8]) <= Convert.ToDateTime(timelast))) 
                            || ((Convert.ToDateTime(splitLine[7]) <= Convert.ToDateTime(timefirst)) 
                            && (Convert.ToDateTime(splitLine[7]) >= Convert.ToDateTime(timelast))))
                        {
                           
                            line2 += line + "\n";
                        }
                    }
                    catch (Exception e)
                    {                       
                        Console.WriteLine("Ошибка:" + e.Message);
                    }

                }
                reader.Close();
                if (line2 == "")
                    line2 = "none";
                return line2;
            }
        }
    }
}
