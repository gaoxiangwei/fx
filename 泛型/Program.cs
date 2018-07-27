using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    /// <summary>
    /// 1 引入泛型：延迟声明
    /// 2 如何声明和使用泛型
    /// 3 泛型的好处和原理
    /// 4 泛型类， 泛型方法， 泛型接口, 泛型委托
    /// 5 泛型约束
    /// 6 协变 逆变
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("第一讲泛型Generic");
                int iValue = 123;
                string sValue = "456";
                DateTime dtValue = DateTime.Now;
                object ovalue = new object();
                Console.WriteLine("=============根据类型进行传值=============");
                CommonMethod.ShowInt(iValue);//需要定义多个方法
                CommonMethod.ShowString(sValue);
                CommonMethod.ShowDateTime(dtValue);

                Console.WriteLine("================以下是object============");
                CommonMethod.ShowObject(ovalue);
                CommonMethod.ShowObject(iValue);
                CommonMethod.ShowObject(sValue);
                CommonMethod.ShowObject(dtValue);

                Console.WriteLine("================以下是泛型============");
                GenericMethod.Show<int>(iValue);//类型参数必须和参数匹配不能定义int类型传智的是string类型
                GenericMethod.Show<string>(sValue);
                GenericMethod.Show<DateTime>(dtValue);
                GenericMethod.Show<object>(ovalue);

                Console.WriteLine("=======================================");
                People people = new People() {
                    Id = 11,
                    Name = "安帖"
                };
                Constraint.Show<People>(people);

                Chinese chinses = new Chinese() {
                    Id = 123,
                    Name="pig猪"
                };
                Constraint.Show<Chinese>(chinses);

                Huber huber = new Huber()
                {
                    Id = 1233,
                    Name = "小胡"
                };
                Constraint.Show<Huber>(huber);
                //Constraint.ShowInterface<People>(people);//没有实现接口，

                Janpan janpan = new Janpan() {
                    Id = 112,
                    Name="鬼子"
                };
                Constraint.ShowInterface<Janpan>(janpan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();

        }
    }
}
