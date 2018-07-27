using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型.NewClass
{
    public class genericClass<T>
    {
        /// <summary>
        /// 可以做参数
        /// </summary>
        /// <param name="t"></param>
        public void Show(T t)
        {
            Console.WriteLine(t);
        }
        /// <summary>
        /// 也可以做返回值
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public T Get(T t)
        {
            return t;
        }
        /// <summary>
        /// 也可以声明多个
        /// </summary>
        /// <typeparam name="W"></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <typeparam name="Y"></typeparam>
        public void GetShow<W, X, Y>()
        { }

    }

    /// <summary>
    /// 也可以声明接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGet<T>
    { }
    /// <summary>
    /// 委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public delegate void GetHandler<T>();

    /// <summary>
    /// 一个普通类继承泛型类
    ///  public class ChildClass : genericClass<int>,可以直接给类型，也可以暂时不给
    /// </summary>
    public class ChildClass<T> : genericClass<T>
    {

        private Child child = new Child();
    }

    public class Parent
    {
        public Parent(string name)
        { }
    }

    /// <summary>
    /// 父类方法里面添加了一个string类型，而Child里面没有添加，
    /// 在ChildClass里面调用的时候默认是调用父类Parent
    /// 因为Child继承了Parent，而Child又没有类型参数，如果直接调用，就会报错
    /// 那么就需要添加base("123")在child里面直接直接给出值
    /// </summary>
    public class Child:Parent
    {
        //为什么这里要加base的问题
        public Child():base("123")
        { }
    }
}

