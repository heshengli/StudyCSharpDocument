using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using EntityFramework.Utilities;

using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDbEntity context = new TestDbEntity();
            //DateTime dt = DateTime.Now;


            //List<Info> infoList = new List<Info>();
            //for (int i = 0; i < 10000; i++)
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
            //DateTime enddt1 = DateTime.Now;
            //TimeSpan ts1 = new TimeSpan(enddt1.Ticks - dt.Ticks);
            //Console.WriteLine("Add SaveChanges:" + ts1.TotalSeconds);

            ////var removeList = context.Info.Where(t => t.ID > 0);
            ////context.Info.RemoveRange(removeList);


            ////int[] ids = new[] {1,2,3,4,5,6,7,8,9,10 };

            ////EFBatchOperation.For(context, context.Info).Where(t => ids.Contains(t.ID)).Delete();
            ////foreach (var item in context.Info.AsEnumerable())
            ////{
            ////    context.Info.Remove(item);
            ////}
            //DateTime enddt2 = DateTime.Now;
            //TimeSpan ts2 = new TimeSpan(enddt2.Ticks - enddt1.Ticks);
            //Console.WriteLine("RemoveRange:"+ts2.TotalSeconds);
            ////context.SaveChanges();
            ////DateTime enddt3 = DateTime.Now;
            ////TimeSpan ts3 = new TimeSpan(enddt3.Ticks - enddt2.Ticks);
            ////Console.WriteLine("RemoveRange SaveChanges:" + ts3.TotalSeconds); 

            ObjectContext objectcontext = ((IObjectContextAdapter) context).ObjectContext;
            //DbContext dbContext = (DbContext)context;
            int[] ids = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string sql = ((ObjectQuery)(objectcontext.CreateObjectSet<Info>()).Where(t => ids.Contains(t.ID))).ToTraceString();
            Console.WriteLine(sql);
            Console.ReadKey();
        }
    }
}
