using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strList = new ArrayList();
            strList.AddRange(new string[] { "1", "2", "3" });
            Console.WriteLine(strList.Count);
            strList.Add("4");
            Console.WriteLine(strList.Count);
            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
