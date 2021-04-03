using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T, M>
    {
        T[] t_items;
        M[] m_items;
        //constroctur
        public MyDictionary()
        {
            t_items = new T[0];
            m_items = new M[0];
        }

        public void Add(T t_item, M m_item)
        {
            T[] t_array = t_items;  //gecici diziye aktardım
            M[] m_array = m_items;

            t_items = new T[t_items.Length + 1];
            m_items = new M[m_items.Length + 1];

            for (int i = 0; i < t_array.Length; i++)
            {
                t_items[i] = t_array[i];
            }
            t_items[t_items.Length - 1] = t_item;

            for (int j = 0; j < m_array.Length; j++)
            {
                m_items[j] = m_array[j];
            }
            m_items[m_items.Length - 1] = m_item;

        }
        public int Count
        {
            get { return t_items.Length; }
        }
    }
}
