using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    /// <summary>
    /// 协变逆变
    /// 只能放在接口或者委托
    /// out 协变convariant 修饰返回值
    /// in 协变 contravariant 修饰传入参数
    /// </summary>
   public class CCTest
    {
        public static void Show() {
            {
                Bird parent1 = new Bird();
                Bird parent2 = new Sparrow();
                Sparrow child = new Sparrow();
            }
            {
                List<Bird> birdList = new List<Bird>();
                //List<Bird> birdList1 = new List<Sparrow>();//两个list泛型实例不存在继承关系,
                //每只麻雀都是一只鸟，但是list不知道，需要强制去转
                List<Bird> birdList2 = new List<Sparrow>().Select(c=>(Bird)c).ToList();//把每一只麻雀转换为bird

            }
            {
                IEnumerable<Bird> birdList1 = new List<Bird>();
                IEnumerable<Bird> birdList2 = new List<Bird>();
            }
            {
                ICustomerListOut<Bird> customerList = new CustomerListOut<Bird>();
                ICustomerListOut<Bird> customerList1 = new CustomerListIn<Sparrow>();
            }
        }
    }


    public class Bird
    {
        public int Id { get; set; }
    }

    public class Sparrow : Bird
    {
        public string Name { get; set; }
    }
    public interface ICustomerListOut<in T>
    {
        void Show(T t);
    }
    public interface ICustomerListIn<in T>
    {
        void Show(T t);
    }

    public interface CustomerListOut<in T>
    {
        void Show(T t);
    }

}

