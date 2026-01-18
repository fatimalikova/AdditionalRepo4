using System.Collections;
using System.Collections.Generic;

namespace PracticeGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Generics!");
            #region Dictionary
            //Dictionary<decimal, string> Dictionary = new Dictionary<decimal, string>();
            //Dictionary.Add(1.1m, "One Point One");
            //Dictionary.Add(2.2m, "Two Point Two");
            //foreach (var item in Dictionary)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SortedList
            //SortedList<byte, string> sortedList = new SortedList<byte, string>();
            //sortedList.Add(3, "Three");
            //sortedList.Add(1, "One");
            //sortedList.Add(2, "Two");
            //sortedList.Remove(3);
            //sortedList.Add(4, "Four");
            ////bool result = sortedList.TryAdd(5, "Five");
            ////Console.WriteLine(result);
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack
            //Stack<string> stack = new();
            //stack.Push("First");
            //stack.Push("Second");
            //stack.Push("Third");
            //stack.Pop();
            //Console.WriteLine(stack.Contains("Four"));
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Queue
            //Queue<int> queue = new();
            //queue.Enqueue(20);
            //queue.Enqueue(10);
            //queue.Enqueue(30);
            //queue.Dequeue();
            //Console.WriteLine(queue.Contains(10));
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region HashTable
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "One");
            //hashtable.Add(2, "Two");
            //hashtable.Add(4, "Four");   
            //hashtable.Add(3, "Three");
            //// hashtable.Remove(2);
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //} 
            #endregion
        }
    }
}
