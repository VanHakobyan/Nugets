using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Scrapping.AllPossibilities
{
    public static class Helpers
    {
        /// <summary>
        ///  Write your collection to csv 
        ///  NOTE: Values must not contain "," character 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="path">Full path with extension</param>
        public static bool WriteCollectionToCsv<T>(IEnumerable<T> items, string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                var itemType = typeof(T);
                var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                    foreach (var item in items)
                    {
                        writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        //TODO: Will TEST.
        public static bool WriteCollectionToCsvNew<T>(IEnumerable<T> items, string path)
        {
            try
            {
                var itemType = typeof(T);
                var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine($"\"{string.Join(", ", props.Select(p => p.Name))}\"");

                    foreach (var item in items)
                    {
                        writer.WriteLine($"\"{string.Join(", ", props.Select(p => p.GetValue(item, null)))}\"");
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
