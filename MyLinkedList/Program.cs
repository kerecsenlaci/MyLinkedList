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
