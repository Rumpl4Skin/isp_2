using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
        class Program
        {
            static string obr(string str)
            {
                StringBuilder s = new StringBuilder(str);
                s = s.Insert(s.Length, s[0]);
                return s.ToString();
            }

        static bool prov(string str)
        {
            bool v = true;
            StringBuilder s = new StringBuilder("qwertyuiopasdfghjklzxcvbnm");
            for (int i = 0; i < s.Length; i++)
                if (str == s[i].ToString() || str == s[i].ToString().ToUpper())
                { v = false; }
            return v;

        }

        static void Main(string[] args)
            {

                Console.WriteLine("Введите строку");
                string input = Console.ReadLine();
                string[] strNumbers = input.Split();
                string[] strObr = strNumbers;

                for (int i = 0; i < strObr.Length; i++)
                    strObr[i] = obr(strObr[i]);

                Console.WriteLine("Обработанный массив (первый символ в конец слова): ");
                for (int i = 0; i < strObr.Length; i++)
                    Console.Write(strObr[i] + " ");

                Console.WriteLine();

                Console.WriteLine("Обработанный массив 2 (порядок вывода слов наоборот): ");
                for (int i = strNumbers.Length - 1; i >= 0; i--)
                    Console.Write(strNumbers[i] + " ");

            Console.WriteLine();

            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            StringBuilder s = new StringBuilder(str);
            for (int i = 0; i < s.Length; i++)
                if (s[i].ToString() == (s[i].ToString()).ToUpper()&&prov(s[i].ToString()))
                    Console.WriteLine(s[i]+" ");
                Console.ReadLine();

            }
        }
}
