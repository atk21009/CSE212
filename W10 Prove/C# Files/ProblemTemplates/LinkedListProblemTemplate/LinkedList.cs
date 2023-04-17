using System.Collections;

namespace LinkedListProblemTemplate;

public class LinkedList: IEnumerable<string>
{
    private Node? _head;
    private Node? _tail;

// TODO - Complete each function so that the user is able to insert and remove nodes correctly

    public void InsertHead(string website)
    {       
    }
    
    public void InsertTail(string website)
    {        
    }
    
    public void RemoveHead() 
    {       
    }
    
    public void RemoveTail() 
    {       
    }
    
    public void InsertAfter(string website, string newWebsite)
    {     
    }
    
    public void Remove(string value)
    {
    }

    public void ClearList()
    {
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