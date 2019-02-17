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
            //リストに連続した値を代入する(0,1,2,3,‥9が生成される)
            var continuousList = Enumerable.Range(0, 10).ToList().AsReadOnly();

            var hash = new HashingMethod(continuousList);

            foreach (var i in continuousList) {
                Console.WriteLine($"リスト(continuousList)の値{i}をハッシュ値に変換します。");
                hash.HashValueCreater(i);
            }
            //ハッシュの衝突をおこすため、もう一度同じこと(foreach)をする
            foreach (var i in continuousList)
            {
                Console.WriteLine($"リスト(continuousList)の値{i}をハッシュ値に変換します。");
                hash.HashValueCreater(i);
            }

            Console.WriteLine($"*****リストの値を全てハッシュ変換しました。*****");

            var revrList = Enumerable.Reverse(continuousList).ToList();


            //************************************************************************************************
            //Education(個人学習用)
            //************************************************************************************************
            Console.WriteLine(Education.Stetementer()); //returnで「0」が返ってくるから「0」が出力される
        }
    }
}




//}



////③ハッシュ探索法　 探したい値は「6」の場合
//var arrayNumber3 = new int[10] { 1, 3, 5, 7, 9, 2, 4, 6, 8 ,10};
//var arrayH = new int[20];//ハッシュ計算結果を入れる配列　大きさは2倍とっておく

////余りの値と格納先の添え字を一致させるように格納する
//foreach (var i in arrayNumber3) {
//    var k = 0;
//    k = i % 20;//格納先が20個なので20で割る(手作りハッシュ計算)
//    if (arrayH[k] == 0) {
//        arrayH[k] = arrayNumber3[i];
//    }


//}





//var list = new List<String>();

//for (var i = 0; i < 100; i++)
//{
//    var str = i.ToString();
//    list.Add(str);
//}
////list.ForEach(i => Console.WriteLine(i));
//list.ForEach(Console.WriteLine);

