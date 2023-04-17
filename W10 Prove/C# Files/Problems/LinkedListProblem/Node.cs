namespace LinkedListProblem;

public class Node
{
    public string Website { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(string website)
    {
        this.Website = website;
    }
}