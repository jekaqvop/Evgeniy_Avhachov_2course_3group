using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_13
{
   
    public static class AESDirInfo
    {
        
        static string GetParentDirs(DirectoryInfo dir)
        {
           
            if (dir.Parent == null)
                return dir.Name + "\n ";

            return dir.Name + " " + GetParentDirs(dir.Parent) ;
        }
        public static string GetDirInfo(string path)
        {
            AESLog.Writer("GetDirInfo", path);
            DirectoryInfo dir = new DirectoryInfo(path);
            string str = "\nКоличество файлов: " + dir.GetFiles().Length
                + "\nДата создания: " + dir.CreationTime
                + "\nКоличество поддиректориев: " + dir.GetDirectories().Length
                + "\nСписок родительских директориев: " + GetParentDirs(dir.Parent);
            return str;
        }
    }
}
