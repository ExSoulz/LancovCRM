using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LCService
{
    static class SettingsReader
    {
        public static List<string> Brands = new List<string>();
        public static List<string> TechTypes = new List<string>();

        public static void Load()
        {
            StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Brands.txt"));
            while (!sr.EndOfStream)
            {
                Brands.Add(sr.ReadLine().ToString());
            }

            sr.Close();

            sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TechTypes.txt"));
            while (!sr.EndOfStream)
            {
                TechTypes.Add(sr.ReadLine().ToString());
            }

            sr.Close();
        }
    }
}
