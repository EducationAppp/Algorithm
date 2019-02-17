using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Education
    {
        public static int Stetementer() {
            //「continue」「break」「return」の学習
            //continue;処理を打ち切って繰り返しを続行
            //break   :繰り返しをその場で終了
            //return  :メソッドの実行を打ち切って、呼び出し側に戻る
            for (int i = 0; i < 10; i++)
            {
                if (i < 4)
                {
                    continue;//処理を打ち切るので、1,2,3は出力されないが繰り返し処理は続行される
                }
                if (i == 7)
                {
                    break;//繰り返しをその場で終了させるので、7,8,9は出力されない
                }
                Console.WriteLine(i);
            }
            return 0;//Stetementerメソッドを打ち切り、呼び出し側に戻る
        }
            
    }
}
