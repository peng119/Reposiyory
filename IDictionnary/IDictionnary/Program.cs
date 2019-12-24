using System;
using System.Collections;
using CDS006.IDictionaryDemo;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            // 创建字典并添加元素
            IDictionary d = new SimpleDictionary(2);
                d.Add("小小", 201801);
                d.Add("大大", 201802);
            Console.WriteLine("字典元素是否包含 '小小'? {0}", d.Contains("小小"));
            
            // 显示所有的 key/value 对
            foreach (DictionaryEntry de in d)
            {
                Console.WriteLine("{0} {1} 。", de.Key, de.Value);
            }

            Console.ReadKey();
        }
    }
}

