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
            list.RemoveAt(2);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            string[] str = new string[4];
            list.CopyTo(str,3);
            Console.WriteLine(str[1]);

            DoubleLinkedList<string> dList = new DoubleLinkedList<string>();
            dList.Add("Béla1");
            dList.Add("Béla2");
            dList.Add("Béla3");
            dList.Add("Béla4");
            dList.Add("Béla5");
            dList.Add("Béla6");
            dList.Add("Béla7");
            dList.Add("Béla8");

            Console.WriteLine(dList[2]);

            foreach (var item in dList)
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
