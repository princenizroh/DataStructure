namespace CostumLinkedList
{
  public class LinkedList<T>
  {
    public Node<T>? Head { get; private set; } // Head property

    public Node<T>? Tail { get; private set; } // Tail property

    public int Count { get; private set; } // Count property

    public LinkedList () // Constructor
    {
      Head = null;
      Tail = null;
      Count = 0;
    }

    public void AddFirst (Node<T> newNode) // AddFirst method
    { 
     
      if (Head == null) // If the list is empty
      {
        Head = newNode; // Set the head and tail to the new node
        Tail = newNode;
      }
      else // If the list is not empty
      {
        newNode.Next = Head; // Set the new node's next to the head
        Head = newNode; // Set the head to the new node
      }

      Count++; // Increment the count
    }

    public void AddLast (Node<T> newNode) // AddLast method
    {
      if (Head == null) // If the list is empty
      {
        Head = newNode; // Set the head and tail to the new node
        Tail = newNode;
      }
      else // If the list is not empty
      {
        Tail!.Next = newNode; // Set the tail's next to the new node \\ change
        Tail = newNode; // Set the tail to the new node
      }

      Count++; // Increment the count
    }

    public void AddAfter(Node<T> newNode, Node<T> existingNode) // AddAfter method
    {
      if (Tail == existingNode) // If the existing node is the tail
      {
        AddLast (newNode); // Add the new node to the end of the list
      }
      else // If the existing node is not the tail
      { 
        newNode.Next = existingNode.Next; // Set the new node's next to the existing node's next
        existingNode.Next = newNode; // Set the existing node's next to the new node
        Count++; // Increment the count
      }
    } 

    public Node<T>? Find(T target)
    {
      Node<T>? currentNode = Head; // Set the current node to the head

      while (currentNode != null && !currentNode.Data.Equals(target)) // While the current node is not null
      {
        currentNode = currentNode.Next;
      }
      return currentNode;
    }
    public void RemoveFirst () // RemoveFirst method
    {
      if (Head == null || Count == 0) // If the list is empty
      {
        // nothing to do. Return
        return;
      }

     Head = Head.Next;
     Count--;
    }
    
    public void Remove(Node<T> doomedNode)
    {
      if (Head == null || Count == 0) // If the list is empty
      {
        return;  
      }

      if (Head == doomedNode) // If the doomed node is the head
      {
        RemoveFirst (); // Remove the first node
        return;
      }
      else // If the doomed node is not the head
      {
        Node<T> previous = Head; // Set the previous node to the head
        Node<T> current = previous.Next; // Set the current node to the head

        while (current != null && current != doomedNode) // While the current node is not null and the current node's next is not the doomed node
        {
          previous = current; // Set the previous node to the current Node
          current = previous.Next; // Set the current node to the previous node's next
        }

        if (current != null) // If the current node is null
        {
          previous.Next = current.Next; // Set the previous node's next to the current node's next
          Count--; // Decrement the count
        }

        current.Next = doomedNode.Next; // Set the current node's next to the doomed node's next
        Count--; // Decrement the count
      }
    }
    public void Traverse()
    {
      if (Head == null)
      {
        Console.WriteLine("The list is empty.");
        return;
      }
      Console.WriteLine("\nHead " + Head.Data);
      Console.WriteLine("Tail " + Tail.Data);

      Node<T>? node = Head;

      while (node != null)
      {
        Console.WriteLine(node.Data);
        node = node.Next;
      }
     
    }
  }
}
