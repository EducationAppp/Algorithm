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
        private ReadOnlyCollection<string> _numsList;
        private Dictionary<string, List<string>> _hashValueList = new Dictionary<string, List<string>>();

        //コンストラクタ
        public HashingMethod(ReadOnlyCollection<string> nums) {
            _numsList = nums;
        }

        public void HashValueCreater(string[] name)
        {
            var hashValue = name[1].GetHashCode();
            Console.WriteLine($"{name[1]}のハッシュ値は{hashValue}です。");

            //キーの存在チェック
            if (_hashValueList.ContainsKey(name[0]))
            {
                List<string> list = _hashValueList[name[0]];
                list.Add(name[1]);
            }
            else {
                List<string> list = new List<string>();
                list.Add(name[1]);
                _hashValueList[name[1]] = list;

            }
            
        }

        public void HashSearcher(string Name) {
            var hashValue = Name.GetHashCode();



        }

    }
}
