using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_13
{
    class AESFileManager
    {
        public static string ReadListFilesAndDirs(string nameDisk = "D")
        {
            DirectoryInfo disk = new DirectoryInfo(nameDisk + @":\");
            string filesAndDirs = "";
            foreach (var file in disk.GetFiles())
                filesAndDirs += file + "; ";
            foreach (var dir in disk.GetDirectories())
                filesAndDirs += dir + "; ";
            return "Папки и файлы на диске " + nameDisk + ": " + filesAndDirs;
            AESLog.Writer("ReadListFilesAndDirs", nameDisk);

        }
        public static void CreateDirAndFile(string path = "")
        {
            try
            {
                Directory.CreateDirectory(path + "AESInspect");          
                StreamWriter writer = new StreamWriter(path + @"AESInspect\AESInspect.txt");
                writer.WriteLine(ReadListFilesAndDirs("D"));
                writer.Close();
                AESLog.Writer("CreateDirAndFile", path, "AESInspect.txt");

                File.Copy(path + @"AESInspect\AESInspect.txt", path + @"AESInspect\CopyAESInspect.txt");
                File.Delete(path + @"AESInspect\AESInspect.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка: {0}", e.Message);
            }
            
        }
        public static void CopyDir(string path1, string exp)
        {
            if (Directory.Exists(path1))
            {
                try
                {
                    DirectoryInfo dir1 = new DirectoryInfo(path1);
                    DirectoryInfo dir2 = Directory.CreateDirectory("AESFiles");
                    AESLog.Writer("CopyDir", path1, "AESFiles");

                    foreach (var x in dir1.GetFiles())
                    {
                        if(exp == Path.GetExtension(x.FullName))
                            x.CopyTo(dir2.FullName + @"\" + x.Name);
                    }

                    if (Directory.Exists("AESInspect"))
                    {                    
                            Directory.Move("AESFiles", @"AESInspect\AESFiles");
                                     
                    }
                    else
                    {
                        throw new Exception("There is no such directory!!!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("ОШИБКА CopyDir: " + e.Message);
                }

            }
            else
            {
                throw new Exception("There is no such directory!!!");
            }
            
        }

        public static void XreateZIP(string dir)
        {
            string zipName = @"HDVFiles.zip";
            if (new DirectoryInfo("HDVInspect").GetFiles("*.zip").Length == 0)
            {
                ZipFile.CreateFromDirectory(dir, zipName);
                AESLog.Writer("CrearteZip", dir, zipName);

                DirectoryInfo direct = new DirectoryInfo(dir);
                foreach (var innerFile in direct.GetFiles())
                    innerFile.Delete();
                direct.Delete();
                ZipFile.ExtractToDirectory(zipName, dir);
            }
        }
    }
}
