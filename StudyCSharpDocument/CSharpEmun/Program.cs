using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEmun
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEnum testEnum = TestEnum.A;
            Console.WriteLine(testEnum.ToString());

            Console.WriteLine(Enum.GetName(typeof(TestEnum), testEnum));
            Console.WriteLine(testEnum.GetEnumName());
            Array enumArray= Enum.GetValues(testEnum.GetType());
            for (int i=0; i<enumArray.Length;i++)
            {
                Console.WriteLine("Name:{0},Value:{0:D}",enumArray.GetValue(i));
            }
            Console.ReadKey();

        }
    }

    public enum TestEnum
    {
        A=1,
        B=2,
        C=4
    }
}
