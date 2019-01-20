using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace アルゴリズム
{
    class Program
    {
        static void Main(string[] args)
        {
            //①線形探索法(リニアサーチ)
            var arrayNumber = new int[10] { 1,3,5,7,9,0,2,4,6,8};
            foreach(var i in arrayNumber) {
                if (i == 6)
                {
                    Console.WriteLine("線形探索法(リニアサーチ)で探しました");
                }
            };






            //var list = new List<String>();

            //for (var i = 0; i < 100; i++) {
            //    var str = i.ToString();
            //    list.Add(str);
            //}
            ////list.ForEach(i => Console.WriteLine(i));
            //list.ForEach(Console.WriteLine);
        }
    }
}
