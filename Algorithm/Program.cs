using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //線形探索法(リニアサーチ)
            LinearSearch.LinearSearcher(6);
            //************************************************************************************************
            //2分探索法(バイナリサーチ)
            var numbers = new int[]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16
            }.ToList().AsReadOnly();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{i}という値がリスト(numbers)の何番目にあるのかを探します。");
                var  index= new BinarySearch(numbers).SearchIndex(i);
                //インデックス番号は0始まりなので、1始まりで数えたいため、「+1」する
                index = index + 1;
                Console.WriteLine($"{i} の場所は {index} 番目です。");
            }
            //************************************************************************************************
            //ハッシュ探索法
            var filePath = @"../../../Data/Employee.csv";

            var lines = File.ReadAllLines(filePath,Encoding.UTF8);

            //HashingMethodメソッドの受け取る引数の型がReadOnlyCollectionのため、渡すときからAsReadOnly()にしなければいならない
            var hash = new HashingMethod(lines .ToList().AsReadOnly());

            foreach (var line in lines) {
                var items = line.Split(',');
                Console.WriteLine($"リスト(continuousList)の値:「{items[0]}:{items[1]}」の「{items[1]}」部分をハッシュ値に変換します。");
                hash.HashValueCreater(items);
            }

            Console.WriteLine($"'\\n'*****リストの値を全てハッシュ変換しました。*****");

            foreach (var line in lines.Reverse())
            {
                var items = line.Split(',');
                Console.WriteLine($"リスト(continuousList)に(Value)値:「{items[1]}」が存在するか確認します。");

                var item = items[1];
                hash.HashSearcher(item);
            }


            //************************************************************************************************
            //Education(個人学習用)
            //************************************************************************************************
            Console.WriteLine(Education.Statementer()); //returnで「0」が返ってくるから「0」が出力される
        }
    }
}

