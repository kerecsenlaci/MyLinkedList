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
            Console.WriteLine(list[0]);



            Console.ReadLine();
        }
    }
}
