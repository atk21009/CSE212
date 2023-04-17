using System.Collections;

namespace TreeProblem;

public class FootballRosterTree: IEnumerable<Tuple<int,string,string>>
{
    public Node? Root;

    public Tuple<int, string, string>? Data;

    public void Insert(int number, string fName, string lName)
    {
        Data = new Tuple<int, string, string>(number, fName, lName);
        if (Root is null)
            Root = new Node(Data);
        else
            Root.Insert(Data);
        
        
    }
    public IEnumerator<Tuple<int, string, string>> GetEnumerator()
    {
        var numbers = new List<Tuple<int, string, string>>();
        TraverseForward(Root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    private void TraverseForward(Node? node, List<Tuple<int, string, string>> values) 
    {
        if (node is not null)
        {
            TraverseForward(node.Left, values);
            values.Add(node.Player);
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