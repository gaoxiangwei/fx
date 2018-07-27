using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class CommonMethod
    {
        #region 在.netframwork1.0之前没有泛型  的解决方式
        /// <summary>
        /// 打印int值
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowInt(int iParameter)
        {
            Console.WriteLine("This is {0}, parameter ={1}, type={2}",
                typeof(CommonMethod).Name, iParameter.GetType().Name, iParameter);
        }
        /// <summary>
        /// 打印string值
        /// </summary>
        /// <param name="sParameter"></param>
        public static void ShowString(string sParameter)
        {
            Console.WriteLine("This is {0}, parameter ={1}, type={2}",
               typeof(CommonMethod).Name, sParameter.GetType().Name, sParameter);
        }
        /// <summary>
        /// 打印DateTime值
        /// </summary>
        /// <param name="sParameter"></param>
        public static void ShowDateTime(DateTime dParameter)
        {
            Console.WriteLine("This is {0}, parameter ={1}, type={2}",
               typeof(CommonMethod).Name, dParameter.GetType().Name, dParameter);
        }

        /// <summary>
        /// 打印object值
        /// 1 任何父类出现的地方，都可以使用子类来替换（继承的特性）
        /// 2 object是一切类型的父类
        /// 3 object 包含所有类型
        /// </summary>
        /// <param name="sParameter"></param>
        public static void ShowObject(object dParameter)
        {
            Console.WriteLine("This is {0}, parameter ={1}, type={2}",
               typeof(CommonMethod).Name, dParameter.GetType().Name, dParameter);
        } 
        #endregion



    }
}
