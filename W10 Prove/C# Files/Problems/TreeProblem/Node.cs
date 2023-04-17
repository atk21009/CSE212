namespace TreeProblem;

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
        if (data.Item1 < Player.Item1) {
            if (Left is null) 
            {
                Left = new Node(data);
            }
            else 
            {
                Left.Insert(data);
            }
        }
        else 
        {
            if (Right is null) 
            {
                Right = new Node(data);
            }
            else 
            {
                Right.Insert(data);
            }
        }
    }
}