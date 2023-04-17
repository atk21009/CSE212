using System.Collections;

namespace TreeExample;

public class BinarySearchTree: IEnumerable<string>
{
    public Node? _root;
    
    public void Insert(string value)
    {
        value = value.Replace("-", "");
        if (value.Length != 10)
        {
            Console.WriteLine($"Error incorrect number format in {value}. Format must be xxx-xxx-xxxx.");
        }
        else
        {
            if (_root is null)
                _root = new Node(value);
            else
                _root.Insert(value);
        }
        
    }
    public IEnumerator<string> GetEnumerator()
    {
        var numbers = new List<string>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    private void TraverseForward(Node? node, List<string> values) 
    {
        if (node is not null) 
        {
            TraverseForward(node.Left, values);
            values.Add(node.PhoneNumber);
            TraverseForward(node.Right, values);
        }
    }

    public int MaxDepth(Node? node)
    {
        if (node == null)
            return 0;
        else {
            int lDepth = MaxDepth(node.Left);
            int rDepth = MaxDepth(node.Right);
            if (lDepth > rDepth) 
                return (lDepth + 1);
            else
                return (rDepth + 1);
            
        }
    }
}