using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListT
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = new List<int>();
            //intList.AddRange(new int[] { 1, 2, 3 });
            List<int> intList = new List<int>(){ 1, 2, 3 };
            Console.WriteLine(intList.Count);
            intList.Insert(2,4);
            intList.Insert(0,5);
            Console.WriteLine(intList.Count);
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in intList.OrderBy(t => t))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
