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
            list.Add("elem1");
            list.Add("elem2");
            list.Add("elem3");
            list.Add("elem4");
            list.Add("elem5");
            list.Add("elem6");
            list.Add("elem7");
            list.Add("elem8");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



            //Console.WriteLine(list[4]);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.IndexOf("elem 4"));
            //Console.WriteLine(list.Remove("elem 4"));
            //Console.WriteLine(list[2]);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.IndexOf("elem 4"));
            //Console.WriteLine(list.Contains("elem 2"));
            //list.Clear();
            //Console.WriteLine(list.Count);




            Console.ReadLine();
        }
    }
}
