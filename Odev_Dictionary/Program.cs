using System;

namespace Odev_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myNewList = new MyDictionary<string>();
            myNewList.Add("A");
            myNewList.Add("B");
            myNewList.Add("C");
            
            myNewList.Goster();
           
        }
    }
}
