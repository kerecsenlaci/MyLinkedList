using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLinkedListTest;

namespace MyLinkedListTest
{
    [TestClass]
    public class MyLinkedListTest
    {
        [TestMethod]
        public void New_LinkedList_Is_Empty()
        {
            var list = new MyLinkedList<string>();
            Assert.AreEqual(0, list.Count);
            //Assert.IsTrue(list.Count == 0);
        }

        [TestMethod]
        public void ForeachOperation()
        {
            var list = new MyLinkedList<string>();
            var count = 0;
            list.Add("elem1");
            list.Add("elem2");
            list.Add("elem3");
            list.Add("elem4");
            list.Add("elem5");
            foreach (var item in list)
            {
                if (item != null)
                    count++;
            }
            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void RemoveAtTesting()
        {
            var list = new MyLinkedList<string>();
            list.Add("elem1");
            list.Add("elem2");
            list.Add("elem3");
            list.Add("elem4");
            list.Add("elem5");
            list.RemoveAt(0); //Lista első
            list.RemoveAt(2); //Lista középső
            list.RemoveAt(4); //Lista utolsó
            Assert.AreEqual(3, list.Count);
        }

        /*  ****************************************           DoubleLinkedListTest           **************************************************  */

        [TestMethod]
        public void DoubleLinkedList_RemoveAtTesting_and_Add()
        {
            var list = new DoubleLinkedList<string>();
            list.Add("elem1");
            list.Add("elem2");
            list.Add("elem3");
            list.Add("elem4");
            list.Add("elem5");
            list.RemoveAt(0); //Lista első
            list.RemoveAt(2); //Lista középső
            list.RemoveAt(3); //Lista utolsó
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void DoubluLinkedList_ForeachOperation()
        {
            var list = new DoubleLinkedList<string>();
            var count = 0;
            list.Add("elem1");
            list.Add("elem2");
            list.Add("elem3");
            list.Add("elem4");
            list.Add("elem5");
            foreach (var item in list)
            {
                if (item != null)
                    count++;
            }
            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void DoubluLinkedList_Remove()
        {
            var list = new DoubleLinkedList<string>();
            list.Add("elem1");
            list.Add("elem2");
            list.Add("elem3");
            list.Add("elem4");
            list.Add("elem5");
            list.Remove("elem5"); //Lista első
            list.Remove("elem3"); //Lista középső
            list.Remove("elem1"); //Lista utolsó
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(false, list.Remove("elem115"));

        }
    }
}
