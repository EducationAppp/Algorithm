using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//↓ReadOnlyCollectionを使用するために追加
using System.Collections.ObjectModel;

namespace Algorithm
{
    class BinarySearch
    {
        private ReadOnlyCollection<int> _numsList;

        //コンストラクタ
        public BinarySearch(ReadOnlyCollection<int> nums)
        {
            //SearchIndexメソッドで扱うためのリストを初期化
            _numsList = nums;
        }

        public int SearchIndex(int target) {
            int searchBeginIndex = 0;
            int searchEndIndex = _numsList.Count - 1;
            //(searchEndIndex - searchBeginIndex + 1)は添え字の値を元に要素数を計算‥(i)
            //「searchBeginIndex + 」について⇒(i)の計算結果は範囲内の開始終了で考えた場合の数であり、
            //要素番号を求めるには、searchBeginIndexから数える必要があるので、「searchBeginIndex + 」となる。
            var candidateIndex = searchBeginIndex + ((searchEndIndex  - searchBeginIndex + 1) / 2);

            Console.WriteLine($"インデックス番号{searchBeginIndex}～{searchEndIndex}を対象に検索します。");
            Console.WriteLine($"インデックス番号{candidateIndex}を確認します(値は{_numsList[candidateIndex]})");

            while (candidateIndex != target) {

                if (candidateIndex < target)
                {
                    searchBeginIndex = candidateIndex + 1;
                }
                else
                {
                    searchEndIndex = candidateIndex - 1;
                }
                //探索範囲を狭めます
                candidateIndex = searchBeginIndex + ((searchEndIndex - searchBeginIndex + 1) / 2);

                Console.WriteLine($"インデックス番号{searchBeginIndex}～{searchEndIndex}を対象に検索します。");
                Console.WriteLine($"インデックス番号{candidateIndex}を確認します(値は{_numsList[candidateIndex]})");
            }
            //candidateIndex = targetの場合
            return candidateIndex;
        }

    }
}



////添え字で考える
//var firstArray = 0;
//var arrayLength = arrayNumber2.Length;


//    while (firstArray<= arrayLength) {
//        var midArray = (firstArray + arrayLength) / 2;
//        if (arrayNumber2[midArray] == 6)
//        {
//            Console.WriteLine("二分探索法(バイナリサーチ)で探しました");
//            return;
//        }
//        else
//        {
//            if (arrayNumber2[midArray] < 6)
//            {
//                firstArray = midArray + 1;
//            }
//            else
//            {
//                arrayLength = midArray - 1;
//            }
//        }
//    }


