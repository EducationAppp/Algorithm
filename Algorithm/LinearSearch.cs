using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class LinearSearch
    {
        public static void LinearSearcher(int num) {
            var arrayNumber = new int[10] { 1,3,5,7,9,0,2,4,6,8};
            foreach(var i in arrayNumber) {
                if (i == num)
                {
                    Console.WriteLine("線形探索法(リニアサーチ)で探しました");
                    break;
                }
            }
        }

    }
}
