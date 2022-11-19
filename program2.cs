using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arraysmethods
{
    internal class program2
    {
        private static object strl;

        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "this is sample text there";

            str2.Trim();//remove space frim L & R side
            str2.TrimStart();//remove space from left side
            str2.TrimEnd();//remove space from right side
            Console.WriteLine(str1.Length);
            Console.WriteLine(str2.Length);

            string str3 = string.Concat(str1," ",str2);
            //string str3= str1 +"" + str2;
            Console.WriteLine(str3);

            Console.WriteLine(str3.Length ToUpper());
        }
    }
}
