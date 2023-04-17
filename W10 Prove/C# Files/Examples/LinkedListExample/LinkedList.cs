using System.Collections;

namespace LinkedListExample;

public class LinkedList: IEnumerable<string>
{
    private Node? _head;
    private Node? _tail;

    public void InsertTail(string song)
    {
        Node newNode = new Node(song);
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
    
    public void InsertAfter(string song, string newSong)
    {
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Song == song)
            {
                if (curr == _tail)
                {
                    InsertTail(newSong);
                }
                else
                {
                    Node newNode = new Node(newSong);
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

    public IEnumerator<string> GetEnumerator()
    {
        var curr = _head;
        while (curr is not null)
        {
            yield return curr.Song;
            curr = curr.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
    
    public override string ToString() {
        return "<LinkedList>{" + string.Join(", ", this) + "}";
    }
}