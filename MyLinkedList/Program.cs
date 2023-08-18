using System;
using CostumLinkedList;
using Mylinkedlist = CostumLinkedList.LinkedList<string>; // Alias

namespace MyLinkedList
{
  class Program
  {
    static void Main(string[] args)
    {
      Mylinkedlist list = new Mylinkedlist();

      Node<string> node2 = new Node<string>("cat");
      list.AddFirst(node2);
      Node<string> node3 = new Node<string>("dog");
      list.AddFirst(node3);
      Node<string> node4 = new Node<string>("bird");
      list.AddFirst(node4);
      Node<string> node5 = new Node<string>("fish");
      list.AddFirst(node5);

      list.Traverse();

      Console.WriteLine($"The list contains {list.Count} items.");
      
      Console.WriteLine("Add After node2");
      list.AddAfter(new Node<string>("zebra"), node2);
      list.Traverse();

      Node<string> target = list.Find("bird");
      if (target != null)
      {
        Console.WriteLine("Found the node containing " + target.Data);
        list.AddAfter(new Node<string>("parrot"), target);
        list.Traverse();
      }
      else
      {
        Console.WriteLine("Did not find the node containing bird");
      }

      Console.WriteLine("Remove node4 "+ target.Data);
      list.Remove(target);
      list.Traverse();
      Console.WriteLine($"The list contains {list.Count} items.");
    }
  }
}
