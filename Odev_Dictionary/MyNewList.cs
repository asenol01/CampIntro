﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Odev_Dictionary
{
    class MyNewList<T>
    {
        T[] items;
        public MyNewList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        public void Show()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i] + " ");
            }
        }
    }
}
