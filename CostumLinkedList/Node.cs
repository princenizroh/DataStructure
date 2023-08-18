using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumLinkedList
{
  public class Node<T>
  {
    public T Data { get; set; } // Data property

    public Node<T>? Next { get; internal set; } // Next property

    public Node (T data) // Constructor
    {
      Data = data;
      Next = null;
    }
  }
}

