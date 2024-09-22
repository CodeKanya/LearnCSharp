/*
    Collections - Data structure that holds multiple objects or elements .
    .NET provides several types of collections, each designed to handle specific scenarioes
    Collections are part of system.collections
C# Collections Overview
├── Non-Generic Collections (Store objects of any data types)
│   ├── ArrayList
│   ├── Hashtable
│   ├── Queue
│   └── Stack
│
├── Generic Collections(Store specific data types - Type safe, better performance)
│   ├── List<T>
│   ├── Dictionary<TKey, TValue>
│   ├── HashSet<T>
│   ├── Queue<T>
│   ├── Stack<T>
│   └── LinkedList<T>
│
├── Concurrent Collections
│   ├── ConcurrentDictionary<TKey, TValue>
│   ├── ConcurrentBag<T>
│   ├── ConcurrentQueue<T>
│   └── ConcurrentStack<T>
*/
using System.Collections;
using Dumpify;

public class Collection{
    public void LearnNonGenericCollections(){
        // ArrayList
        // dynamically resizing array that can store objects of diffrent types
        // Doesn't require predefined size and automatically as elements are added or removed
        // Poor performance due to boxing/unboxing
        int[] arr = [1,2,3,4];
        ArrayList list = new ArrayList();
        list.Add("first");
        list.Add(1);
        list.Dump();
        list.Remove(1);
        list.Dump();
        list.AddRange(arr);
        list.Dump();
        var listClone = list.Clone();
        listClone.Dump();

        // Hashtable
        // Stores key, value pairs, but without type safety
        // Keys and values must be cast to appropriate type when retrieving them
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1,list);
        hashtable.Add(2,"Two");
        hashtable.Dump();
        hashtable[1].Dump();

        // Queue (FIFO - Fist In First Out)
        // Items are added to the back and removed from the front
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue("dsfdsg");
        queue.Dequeue();
        queue.Dump();

        // Stack (LIFO - Last In First Out)
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push("two");
        stack.Pop();
        stack.Dump();

    }

    public void LearnGenericCollections(){
        // dynamic array that automatically resize when elements are added or removed
        // Allows indexed acces , type safe
        List<string> list = new List<string>();
        list.Add("one");
        list.Add("two");
        list.Dump();
        list.AddRange(new List<string>{"1","1"});
        list.Remove("one");
        list.Dump();
        list[1].Dump();
        list.Count().Dump();

        // Dictionary
        // Store Key-value pair, where each key is unique
        // provides fast lookups by key
        Dictionary<int,string> dictionary = new Dictionary<int,string>();
        dictionary.Add(1,"one");
        dictionary.Add(2,"two");
        dictionary.Dump();
        dictionary[2].Dump();
        dictionary.Remove(1).Dump();
        dictionary.Dump();

        // Queue - FIFO
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("task1");
        queue.Enqueue("task2");
        queue.Enqueue("task3");
        queue.Dequeue();
        queue.Dump();

        // Stack - LIFO
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Pop();
        stack.Dump();

        // HashSet
        // Collection of unique elements (duplicates not allowed)
        // provides fast operation like add, remove and cjecking the existence of of elements
        HashSet<int> numbers = new HashSet<int>(){1,2,3,4,4};
        numbers.Dump();
        numbers.Add(3).Dump();
        numbers.Add(5).Dump();

        // Doubly linked list
        // where each element points to the next and previous elements
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("last");
        linkedList.AddFirst("First");

        linkedList.Dump();

        //SortedList

        //SortedDictioanry


    }

     public void LearnConcurrentCollections(){

    }
}