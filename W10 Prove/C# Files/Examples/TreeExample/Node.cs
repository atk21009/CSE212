namespace TreeExample;

public class Node 
{
    public string PhoneNumber { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(string data) 
    {
        this.PhoneNumber = data;
    }
    public void Insert(string number)
    {
        if (long.Parse(number) < long.Parse(PhoneNumber)) {
            if (Left is null) 
            {
                Left = new Node(number);
            }
            else 
            {
                Left.Insert(number);
            }
        }
        else 
        {
            if (Right is null) 
            {
                Right = new Node(number);
            }
            else 
            {
                Right.Insert(number);
            }
        }
    }
}