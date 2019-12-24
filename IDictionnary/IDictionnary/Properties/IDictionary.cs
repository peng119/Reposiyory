
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionary
{
    /// <summary>
    /// 这个类使用一个 DictionaryEntry 实体实现 “键/值对” 对象集合
    /// </summary>
    public class Dictionary : System.Collections.IDictionary
    {
        // 元素集合
        private DictionaryEntry[] items;  // 元素集合
        private Int32 ItemsInUse = 0;     // 元素使用的数量

        /// <summary>
        /// 构造函数：定义集合元素的数量
        /// 在 SimpleDictionary 的生命周期里，这个数量是不能更改的。
        /// </summary>
        /// <param name="numItems">元素数量</param>
        public Dictionary(Int32 numItems)
        {
            items = new DictionaryEntry[numItems];
        }

        public object this[object key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #region IDictionary 成员，注意这些成员都是 IDictionary 已经定义的，在这里需要具体实现
        public bool IsReadOnly { get { return false; } }

        public bool IsFixedSize => throw new NotImplementedException();

        public ICollection Keys => throw new NotImplementedException();

        public ICollection Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
