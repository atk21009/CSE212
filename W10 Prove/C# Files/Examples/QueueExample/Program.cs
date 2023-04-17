using QueueExample;

Queue<HairCut> hairCutQueue = new Queue<HairCut>();

HairCut task = new HairCut("Taylor", "S");
hairCutQueue.Enqueue(task);
task = new HairCut("John", "D");
hairCutQueue.Enqueue(task);
task = new HairCut("Thomas", "J");
hairCutQueue.Enqueue(task);
task = new HairCut("Jeff", "R");
hairCutQueue.Enqueue(task);
task = new HairCut("Joseph", "S");
hairCutQueue.Enqueue(task);
task = new HairCut("Peter", "Q");
hairCutQueue.Enqueue(task);

Console.WriteLine(string.Join(", ", hairCutQueue)); // Taylor S, John D, Thomas J, Jeff R, Joseph S, Peter Q
        
HairCut serve = hairCutQueue.Dequeue(); 
serve.ServeCustomer();
serve = hairCutQueue.Dequeue();
serve.ServeCustomer();
        
Console.WriteLine(string.Join(", ", hairCutQueue)); // Thomas J, Jeff R, Joseph S, Peter Q