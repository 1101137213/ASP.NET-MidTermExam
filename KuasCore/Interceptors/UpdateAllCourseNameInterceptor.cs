using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Interceptors
{
    public class UpdateAllCourseNameInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            var watch = Stopwatch.StartNew();
            Console.WriteLine("UpdateAllCourseNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateAllCourseNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            /*extra trial*/
            IList<Course> result = (IList<Course>)invocation.Proceed();
            for (int i = 0; i < result.Count; i++)
            {
                Debug.Print(result[i].Course_Name);
                result[i].Course_Name += " HAHAHA" + i;
            }

            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            Debug.Print("回傳的資料已取得 [{0}]", result);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("UpdateAllCourseNameInterceptor 執行時間 : " + elapsedMs + " ms");
            return result;
        }
    }
}