using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCommon.CommonProviders
{
    public class AppDataProvider
    {

        private static string PATH_SEPARATOR = null;


        /**
         * возвращает файловый разделитель 
         */
        public static string GetPathSeparator()
        {
            if (PATH_SEPARATOR == null)
            {
                string path = GetRootDirectory();
                int i0 = path.LastIndexOf("/");
                int i1 = path.LastIndexOf("\\");
                if (i0 > i1)
                {
                    PATH_SEPARATOR = "/";
                }
                else if (i1 > i0)
                {
                    PATH_SEPARATOR = "\\";
                }
                else
                {
                    throw new Exception("ResourceManager: can not compute file path separator");
                }
            }
            return PATH_SEPARATOR;
        }

        /**
         * Получение всех ресурсов каталога AppData
         */
        public static Dictionary<string, object> GetAppData()
        {
            return GetAppDataForDirectory(GetRootDirectory());
        }

        /**
         * Получение всех ресурсов каталога AppData
         */
        public static Dictionary<string, object> GetAppDataForDirectory(string path)
        {
            Dictionary<string, object> resources = new Dictionary<string, object>();
            foreach (string dir in System.IO.Directory.GetDirectories(path))
            {
                string name = dir.Substring(dir.LastIndexOf(GetPathSeparator()) + 1);
                resources[name] = GetAppDataForDirectory(dir);
            }
            foreach (string file in System.IO.Directory.GetFiles(path))
            {
                string name = file.Substring(file.LastIndexOf(GetPathSeparator()) + 1);
                resources[name] = System.IO.File.ReadAllBytes(file);
            }
            return resources;
        }




        /**
         * возвращает абсолютный путь к корневой директории проекта
         */
        private static string GetRootDirectory()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }

        /**
         * возвращает абсолютный путь директории статических ресурсов проекта
         */
        public static string GetAppDataDirectory()
        {
            return System.IO.Directory.GetCurrentDirectory() + @"\AppData";
        }

        /**
         * Возвращает список файлов из заданного подкаталога AppData
         */
        protected static string[] GetAppDataResources(string dir)
        {
            List<string> files = new List<string>(System.IO.Directory.GetFiles(GetAppDataDirectory() + @"\" + dir));
            files.Sort();
            return files.ToArray();
        }


        /**
         * Запись файла в каталог AppData
         */
        public static void WriteAppData(string filename, byte[] data)
        {
            System.IO.File.WriteAllBytes(GetAppDataDirectory() + "/" + filename, data);
        }
    }
}
