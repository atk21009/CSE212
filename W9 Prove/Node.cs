namespace prove_09;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            // Insert to the left
            return Left is not null && Left.Contains(value);
        }
        else
        {
            // Insert to the right
            return Right is not null && Right.Contains(value);
        }
    }

    public int GetHeight() {
        if (Right is null)
        {
            return 1;
        }
        else
        {
            return Right.GetHeight() + 1;
        }
    }
}