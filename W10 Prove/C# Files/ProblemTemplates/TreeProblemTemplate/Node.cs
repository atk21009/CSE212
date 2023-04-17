namespace TreeProblemTemplate;

public class Node
{
    public Tuple<int, string, string> Player { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(Tuple<int, string, string> data) 
    {
        this.Player = data;
    }
    public void Insert(Tuple<int, string, string> data)
    {
        // TODO: Insert Data into node
    }
}