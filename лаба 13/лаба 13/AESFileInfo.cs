using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_13
{
    public static class AESFileInfo
    {
        public static string FileInfo(string path)
        {
            FileInfo file = new FileInfo(path);
            string str = "Полынй путь к файлу" + file.FullName
                + "\nРазмер файла: " + file.Length
                + "\nРасширение файла: " + file.Extension
                + "\nИмя файла: " + file.Name
                + "\nДата создания: " + file.CreationTime
                + "\nДата последнего изменения: " + File.GetLastWriteTime(file.FullName).ToString();
            AESLog.Writer("FileInfo", path);

            return str;
        }
    }
}
