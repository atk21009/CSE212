namespace LinkedListExample;

public class Node 
{
    public string Song { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(string song)
    {
        this.Song = song;
    }
}