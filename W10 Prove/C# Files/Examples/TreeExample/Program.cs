using TreeExample;

BinarySearchTree numberDataBase = new BinarySearchTree();
        
numberDataBase.Insert("123-456-7890");
numberDataBase.Insert("123-123-1231");
numberDataBase.Insert("456-456-4564");
numberDataBase.Insert("789-789-7897");
numberDataBase.Insert("111-222-3333");
numberDataBase.Insert("444-555-6666");
numberDataBase.Insert("777-888-9999");
        
        

foreach (var number in numberDataBase)
{
    var num = number.Insert(3, "-");
    num = num.Insert(7, "-");
    Console.WriteLine(num);
            
}
Console.WriteLine("Max depth: " + numberDataBase.MaxDepth(numberDataBase._root));