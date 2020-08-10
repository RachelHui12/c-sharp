using System;
using System.Collections;
namespace HashtableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable类似于c++的map
            Hashtable hashtable = new Hashtable();
            hashtable["Mr.joj"] = "102921";
            hashtable.Add("Mr. John", "071-222-33445");
            printkeyandvalue(hashtable);
            print2(hashtable);
        }
        static void printkeyandvalue(Hashtable myList)
        {
            IEnumerator ie = myList.Keys.GetEnumerator();
            while (ie.MoveNext())
            {
                object key = ie.Current;
                object value = myList[key];
                Console.WriteLine("\t{0}:\t{1}", key, value);
            }
            Console.WriteLine();
            foreach (string key in myList.Keys)
            {

                Console.WriteLine("\t{0}:\t{1}", key, myList[key]);
            }
        }
        static void print2(Hashtable myList)
        {
            IDictionaryEnumerator myEnumerator = myList.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.WriteLine("\t{0}:\t{1}",myEnumerator.Key, myEnumerator.Value);
            Console.WriteLine();
        }
    }
}
