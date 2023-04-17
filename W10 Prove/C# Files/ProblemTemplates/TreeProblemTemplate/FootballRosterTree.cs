using System.Collections;

namespace TreeProblemTemplate;

public class FootballRosterTree: IEnumerable<Tuple<int,string,string>>
{
    public Node? Root;

    public Tuple<int, string, string>? Data;

    public void Insert(int number, string fName, string lName)
    {
        // TODO: Insert data into tree  
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
        // TODO: Create a function to traverse down tree
    }

    public int MaxDepth(Node? node)
    {
        // TODO: Find max depth of the tree
    }
    
}