using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    public class Themes
    {
        public int n;
        public string[] Name_Students;
        public string[] Student = { "Набор 1", "Набор 2", "Набор 3", "Набор 4", "Набор 5" , "Набор 6", };
        public string[] Theme_str;
        public string[] Theme_str1;
        public string[] Theme_str2;
        public string[] Theme_str3;
        public Theme facultet;
        public Random random;
        public Themes()
        {
            n = 6;
            Name_Students = new string[n];
            Theme_str = new string[n];
            Theme_str1 = new string[n];
            Theme_str2 = new string[n];
            Theme_str3 = new string[n];
            random = new Random();
            int k = 0;
            for (int i = 0; i < Student.Length; i++)
            {
                for (int j = k; j < k + 1; j++)
                {
                    Name_Students[j] = Student[i];
                }
                k += 1;
            }
            int themename;
            for (int i = 0; i < Theme_str.Length; i++)
            {
                themename = random.Next(16);
                Theme theme = (Theme)themename;
                Theme_str[i] = Convert.ToString(theme);
            }
            for (int i = 0; i < Theme_str.Length; i++)
            {
                themename = random.Next(16);
                Theme theme = (Theme)themename;
                Theme_str1[i] = Convert.ToString(theme);
            }
            for (int i = 0; i < Theme_str.Length; i++)
            {
                themename = random.Next(16);
                Theme theme = (Theme)themename;
                Theme_str2[i] = Convert.ToString(theme);
            }
            for (int i = 0; i < Theme_str.Length; i++)
            {
                themename = random.Next(16);
                Theme theme = (Theme)themename;
                Theme_str3[i] = Convert.ToString(theme);
            }
        }
    }
}
