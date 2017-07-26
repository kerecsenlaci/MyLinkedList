using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.InsertAtStart("elem 1");
            list.InsertAtStart("elem 2");
            list.InsertAtStart("elem 3");
            list.InsertAtStart("elem 4");
            list.InsertAtStart("elem 5");
            list.InsertAtStart("elem 6");
            Console.WriteLine(list[4]);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.IndexOf("elem 4"));
            Console.WriteLine(list.Remove("elem 4"));
            Console.WriteLine(list[2]);

            Console.WriteLine(list.Count);
            Console.WriteLine(list.IndexOf("elem 4"));
            Console.WriteLine(list.Contains("elem 2"));
            list.Clear();
            Console.WriteLine(list.Count);




            Console.ReadLine();
        }
    }
}
