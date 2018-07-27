using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{


    public interface ISports
    {
        void PingPang();
    }
    public interface IWork
    {

    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Chinese : People, ISports
    {
        public string Tradition { get; set; }

        public void PingPang()
        {
            Console.WriteLine("打乒乓球");
        }

        public void SayHi()
        {
            Console.WriteLine("吃了么？");
        }
    }

    public class Huber : Chinese
    {
        public string Changjiang { get; set; }
        public void Majiang()
        {
            Console.WriteLine("打麻将了...");
        }
    }

    public class Janpan:ISports
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void PingPang()
        {
            Console.WriteLine("日本人不会打乒乓球");
        }
    }
}
