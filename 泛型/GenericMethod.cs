using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class GenericMethod
    {
        #region 在.netframwork2.0 泛型
        /// <summary>
        /// 1 延迟声明：把参数类型推迟到调用的时候
        /// 2 泛型默认一般是T 其他也是可以的，但是不要用关键字如class
        /// 3 不是语法糖，而是由框架升级才有的
        /// 4 架构：在做架构的时候推迟一切可以推迟的东西
        /// </summary>
        /// <typeparam name="T">传递类型</typeparam>
        /// <param name="iParameter">类型的值</param>
        public static void Show<T>(T iParameter)
        {
            Console.WriteLine("This is {0}, parameter ={1}, type={2}",
                typeof(CommonMethod).Name, iParameter.GetType().Name, iParameter);
        }

        #endregion
    }
}
