using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //①線形探索法(リニアサーチ) 探したい値は「6」の場合
            var arrayNumber = new int[10] { 1,3,5,7,9,0,2,4,6,8};
            foreach(var i in arrayNumber) {
                if (i == 6)
                {
                    Console.WriteLine("線形探索法(リニアサーチ)で探しました");
                }
            };

            //②二分探索法(バイナリサーチ) 探したい値は「6」の場合
            var arrayNumber2 = new int[17] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17};
            //添え字　　　　　　　　　　　　0.1,2,3,4,5,6,7,8,9, 10,11,12,13,14,15,16

            //添え字で考える
            var firstArray = 0;
            var arrayLength = arrayNumber2.Length;


            while (firstArray<= arrayLength) {
                var midArray = (firstArray + arrayLength) / 2;
                if (arrayNumber2[midArray] == 6)
                {
                    Console.WriteLine("二分探索法(バイナリサーチ)で探しました");
                    return;
                }
                else
                {
                    if (arrayNumber2[midArray] < 6)
                    {
                        firstArray = midArray + 1;
                    }
                    else
                    {
                        arrayLength = midArray - 1;
                    }
                }
            }
            





            //var list = new List<String>();

            //for (var i = 0; i < 100; i++)
            //{
            //    var str = i.ToString();
            //    list.Add(str);
            //}
            ////list.ForEach(i => Console.WriteLine(i));
            //list.ForEach(Console.WriteLine);
        }
    }
}
