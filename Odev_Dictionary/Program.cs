using System;

namespace Odev_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewList<string> myNewList = new MyNewList<string>();
            myNewList.Add("A");
            myNewList.Add("B");
            myNewList.Add("C");
            myNewList.Show();
            Console.ReadLine();
        }
    }
}
