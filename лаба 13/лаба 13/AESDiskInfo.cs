using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_13
{
    public static class AESDiskInfo
    {
       public static void HardsSpace()
       {
            var allDrives = DriveInfo.GetDrives();
            foreach (var drive in allDrives)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Имя диска: {drive.Name}");         
               
                Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
                Console.WriteLine($"Файловая система: {drive.DriveFormat}");               
                Console.WriteLine($"Общий объём: {drive.TotalSize / 1073741824} Gbyte");
                Console.WriteLine($"Свободное место: {drive.TotalFreeSpace / 1073741824} Gbyte");
                Console.WriteLine($"Доступное свободное место: {drive.AvailableFreeSpace / 1073741824} Gbyte");
                Console.WriteLine("----------------------");
                AESLog.Writer("HardSpace", drive.Name);

            }
        } 
    }
}
