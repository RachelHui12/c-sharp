using System;
using System.Collections.Generic;

namespace List用法
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>();
            fruit.Add("apple");
            fruit.Add("banana");
            fruit.Add("Carrot");
            Console.WriteLine("count:{0}", fruit.Count);
            printvalue1(fruit);
            printvalue2(fruit);
            printvalue3(fruit);
        }
        static void printvalue1(List<string> mylist)
        {
            for(int i=0;i<mylist.Count;i++)
            {
                Console.Write("{0}\n",mylist[i]);
            }
            Console.WriteLine();
        }
        static void printvalue2(List<string> mylist)
        {
            foreach(string item in mylist)
            {
                Console.Write("{0}\n", item);
            }
            Console.WriteLine();
        }

        static void printvalue3(IEnumerable<string> mylist)
        {
            IEnumerator<string> myenumerable = mylist.GetEnumerator();
            while(myenumerable.MoveNext())
            {
                Console.Write("{0}\n", myenumerable.Current);
            }
            Console.WriteLine();
        }
    }
}
