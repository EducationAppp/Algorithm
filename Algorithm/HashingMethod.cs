using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//↓ReadOnlyCollectionを使用するために追加
using System.Collections.ObjectModel;

namespace Algorithm
{
    class HashingMethod
    {
        private ReadOnlyCollection<int> _numsList;
        private Dictionary<int, int> _hashValueList = new Dictionary<int, int>();

        //コンストラクタ
        public HashingMethod(ReadOnlyCollection<int> nums) {
            _numsList = nums;
        }

        public void HashValueCreater(int num)
        {
            var hashValue = num.GetHashCode();
            Console.WriteLine($"{num}のハッシュ値は{hashValue}です。");

            //キーの存在チェック
            if (!_hashValueList.ContainsKey(hashValue))
            {
                _hashValueList.Add(hashValue, num);
            }
            else {

            }
            
        }

        //public void HashSearcher(int num)

    }
}
