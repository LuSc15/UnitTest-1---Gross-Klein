using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class StringManipulation
    {
        string eingabe = Console.ReadLine();
        public static string[] StringGross(string eingabe)
        {
            string[] wörter = eingabe.Split(" ");
            string[] wörterGross = new string[wörter.Count()];
            int i = 0;
            foreach(string s in wörter)
            {
                wörterGross[i] = char.ToUpper(s[0]) + s.Substring(1);
                i++;
            }
            return wörterGross;
        }
        public static void Ausgabe(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.Write(s + " ");
            }
            Console.Write("\b");
        }
    }
}
