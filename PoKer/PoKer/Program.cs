using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Pokers;

namespace Pokers
{
    enum Color { HongTao = -1, HeiTao = -2, MeiHua = -3, FangPian = -4 }//花色  
    enum point { A, two, three, four, five, six, seven, eight, nine, ten, J, Q, K }//点数  
    class Poker //定义poker类
    {     //扑克  
        private string P1, P2;
        public Poker(string P1, string p2)
        {
            this.P1 = P1;
            this.P2 = p2;
        }
   
        public void Printp()//方法成员
        {
        
            Console.Write("({0},{1})", this.P1, this.P2);
         }
    }

}

    class program
    {

        static void Main(string[] args)
        {
            ArrayList myPoker = new ArrayList();//实例化一个ArrayList存放所有的扑克牌  
            ArrayList Person1 = new ArrayList();
            ArrayList Person2 = new ArrayList();
            ArrayList Person3 = new ArrayList();
            ArrayList Person4 = new ArrayList();
            Random r = new Random();
            for (int i = -4; i <= -1; i++)  //外循环初始化扑克的花色  
            {
                for (int j = 0; j <= 12; j++) //内层循环初始化扑克的点数
                {
                    myPoker.Add(new Poker(
                        Enum.GetName(typeof(Color), i),
                        Enum.GetName(typeof(point), j)  //往mypoker内添加已设计好的枚举元素
                        ));
                }
            }       //for循环结束，52张扑克牌已经生成  
            Console.WriteLine("打印所有的扑克牌：");
            for (int i = 0; i < 52; i++) //打印52张生成的扑克牌  
            {
                Poker poAll = (Poker)myPoker[i];//访问mypoker中的元素
                poAll.Printp();//调用Printp方法
            }

            //开始发牌，一个人一个人的发，每发一张牌得从myPoker中RemoveAt掉扑克牌，Count数减小；第一个人Add到一张牌。  
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);//分配随机数
                Person1.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person2.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person3.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person4.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }

            //打印四个人的扑克牌
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("打印第一个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po1 = (Poker)Person1[i];//访问person1中的元素
                po1.Printp();//再次调用Printp方法
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("打印第二个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po2 = (Poker)Person2[i];
                po2.Printp();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("打印第三个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po3 = (Poker)Person3[i];
                po3.Printp();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("打印第四个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po4 = (Poker)Person4[i];
                po4.Printp();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
