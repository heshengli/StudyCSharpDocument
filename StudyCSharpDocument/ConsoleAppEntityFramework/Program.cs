using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDbEntity context=new TestDbEntity();
            //DateTime dt = DateTime.Now;


            //List<Info> infoList = new List<Info>();
            //for (int i = 0; i < 200000; i++)
            //{
            //    Info info = new Info()
            //    {
            //        Name = "张三" + i,
            //        Content = "张三" + i,
            //        CreateTime = DateTime.Now
            //    };
            //    infoList.Add(info);
            //}
            //context.Info.AddRange(infoList);
            //DateTime enddt = DateTime.Now;
            //TimeSpan ts = new TimeSpan(enddt.Ticks - dt.Ticks);
            //Console.WriteLine("Add:" + ts.TotalSeconds);

            //context.SaveChanges();
            DateTime enddt1 = DateTime.Now;
            //TimeSpan ts1 = new TimeSpan(enddt1.Ticks - dt.Ticks);
            //Console.WriteLine("Add SaveChanges:" + ts1.TotalSeconds);

            var removeList = context.Info.Where(t => t.ID > 0).AsEnumerable();
            context.Info.RemoveRange(removeList);

            //foreach (var item in context.Info.AsEnumerable())
            //{
            //    context.Info.Remove(item);
            //}
            DateTime enddt2 = DateTime.Now;
            TimeSpan ts2 = new TimeSpan(enddt2.Ticks - enddt1.Ticks);
            Console.WriteLine("RemoveRange:"+ts2.TotalSeconds);
            context.SaveChanges();
            //DateTime enddt3 = DateTime.Now;
            //TimeSpan ts3 = new TimeSpan(enddt3.Ticks - enddt2.Ticks);
            //Console.WriteLine("RemoveRange SaveChanges:" + ts3.TotalSeconds);
            Console.ReadKey();
        }


    }
}
