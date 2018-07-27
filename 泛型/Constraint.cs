using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class Constraint
    {
        /// <summary>
        /// 泛型约束：基类约束：
        /// 1 在泛型方法内可以直接使用基类的属性和方法
        /// 2 在调用的时候，只能传递基类或者基类的子类
        /// 3,在调用的时候只能传递一个People不能传递一个int
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iParameter"></param>
        public static void Show<T>(T iParameter) where T:People
        {
            Console.WriteLine("This is  id ={0}, Name={1}",
                iParameter.Id,iParameter.Name);
           
        }
        

        public static void ShowInterface<T>(T tParameter) where T : ISports
        {
            tParameter.PingPang();
        }



        public static T Get<T>(T tParameter)
            //where T:new()//无参构造
            //where T :class//引用类型
            where T:struct//值类型

        {
            //return null;//引用类型
            //值类型可以用，引用类型也可以用，任何类型都可以
            return default(T);//给默认值
        }

        /// <summary>
        /// 多种约束:是and的关系
        /// 在使用class的时候就不能使用people因为它本身就是类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void Many<T>() where T : People, ISports, IWork,new()
        {

        }

    }
}
