using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.DAL
{
    class Utilites
    {
		//
		// Тут можно было все одним методом сделать, они ж одинаковые, просто вставляешь переменную "file"
		//
		public static string CheckFilePath(string file)
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            string data_folder = "Papka";
            string pathString2 = wanted_path + @"/" + data_folder + @"/";
            Directory.CreateDirectory(pathString2);

            DirectoryInfo firstDir = new DirectoryInfo(pathString2);

            int n = 0;
            foreach (var item in firstDir.GetFiles())
            {
                if (item.Name == "Users")
                {
                    n++;
                }
            }
            if (n == 0)
            File.Create(pathString2 + file).Close();

            return pathString2 + file;
        }

        public static string CheckFilePath2(string file)
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            string data_folder = "Papka";
            string pathString2 = wanted_path + @"\" + data_folder + @"\";
            Directory.CreateDirectory(pathString2);

            DirectoryInfo firstDir = new DirectoryInfo(pathString2);

            int n = 0;
            foreach (var item in firstDir.GetFiles())
            {
                if (item.Name == "Awards")
                {
                    n++;
                }
            }
            
            if (n == 0)
            File.Create(pathString2 + file).Close();

            return pathString2 + file;
        }
    }
}
