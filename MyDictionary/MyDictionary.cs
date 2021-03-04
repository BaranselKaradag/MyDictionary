using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;

        TValue[] values;
        public int count { get; set; }





        public MyDictionary()
        {
            keys = new TKey[1];
            values = new TValue[1];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] tempKey = new TKey[keys.Length];
            TValue[] tempValue = new TValue[values.Length];
            tempKey = keys;
            tempValue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }


        public void Show(TKey key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if(Convert.ToString(i)==Convert.ToString(key))
                {
                  count=0;
                  count=i;
                }
            }
            if (count!=0)
            {
                Console.WriteLine(keys[count]+ ": "+values[count]);
            }

            else
            {
                Console.WriteLine("Değer Mevcut Değil.........");
            }
        }


        public void Listele()
        {
            for (int i = 0; i < keys.Length; i++)
            {

                Console.WriteLine(keys[i]+ " "+ values[i]);

            }

        }


    }
}
