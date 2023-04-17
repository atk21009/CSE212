using System.Collections;

namespace LinkedListProblem;

public class LinkedList: IEnumerable<string>
{
    private Node? _head;
    private Node? _tail;

    public void InsertHead(string website)
    {
        Node newNode = new Node(website);
        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Prev = newNode;
            _head = newNode;
        }
    }

    
    public void InsertTail(string website)
    {
        Node newNode = new Node(website);
        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Prev = _tail;
            _tail!.Next = newNode;
            _tail = newNode;
        }
    }
    
    public void RemoveHead() {
        if (_head == _tail) {
            _head = null;
            _tail = null;
        }
        else if (_head is not null) {
            _head.Next!.Prev = null;
            _head = _head.Next; 
        }
    }
    public void RemoveTail() {
        if (_head == _tail) {
            _head = null;
            _tail = null;
        }
        else
        {
            _tail!.Prev!.Next = null;
            _tail = _tail.Prev;
        }
    }

    
    public void InsertAfter(string website, string newWebsite)
    {
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Website == website)
            {
                if (curr == _tail)
                {
                    InsertTail(newWebsite);
                }
                else
                {
                    Node newNode = new Node(newWebsite);
                    newNode.Prev = curr;
                    newNode.Next = curr.Next;
                    curr.Next!.Prev = newNode;
                    curr.Next = newNode;
                }
                return;
            }
            curr = curr.Next;
        }
    }
    
    
    public void Remove(string value)
    {
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Website == value)
            {
                if (curr == _tail)
                {
                    RemoveTail();
                }
                else if (curr == _head)
                {
                    RemoveHead();
                }
                else
                {
                    curr.Prev!.Next = curr.Next;
                    curr.Next!.Prev = curr.Prev;
                }
                return;
            }

            curr = curr.Next;
        }
    }

    public void ClearList()
    {
        Node? curr = _tail;
        while (curr is not null)
        {
            RemoveTail();
            curr = _tail!.Prev;
        }

        _head = null;
    }
    public IEnumerator<string> GetEnumerator()
    {
        var curr = _head;
        while (curr is not null)
        {
            yield return curr.Website;
            curr = curr.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public void PrintList()
    {
        var curr = _head;
        while (curr is not null)
        {
            Console.WriteLine(curr.Website);
            curr = curr.Next;
        }
    }
    public override string ToString() {
        return "<LinkedList>{" + string.Join(", ", this) + "}";
    }
}