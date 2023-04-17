using LinkedListExample;


var ll = new LinkedList();
ll.InsertTail("Baby");
ll.InsertTail("We Are Young");
ll.InsertTail("Dancing Queen");
ll.InsertTail("My House");
        
Console.WriteLine(ll.ToString()); // <LinkedList>{Baby, We Are Young, Dancing Queen, My House}
        
ll.InsertAfter("We Are Young", "Riptide");
ll.InsertAfter("Dancing Queen", "Little Talks");
Console.WriteLine(ll.ToString()); // <LinkedList>{Baby, We Are Young, Riptide, Dancing Queen, Little Talks, My House}