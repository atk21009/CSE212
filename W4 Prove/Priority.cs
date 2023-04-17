namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add value to priority queue and remove queue
        // Expected Result: List should end empty
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Test", 1);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Need to add a RemoveAt function to remove highest priority

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Have two priority 2 queues and 3 priority 1 queues
        // Expected Result: Remove the two priority 2 queues 
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Test P1", 1);
        priorityQueue.Enqueue("Test P2", 2);
        priorityQueue.Enqueue("Test P1_2", 1);
        priorityQueue.Enqueue("Test P2_2", 2);
        priorityQueue.Enqueue("Test P1_3", 1);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None found

        Console.WriteLine("=================");

        // Test 3
        // Scenario: Add priority from 1-4 and priority 1 and two at end then, remove 4
        // Expected Result: Result should be 2 priority 1 cases left
        Console.WriteLine("Test 3");

        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Test P1", 1);
        priorityQueue.Enqueue("Test P2", 2);
        priorityQueue.Enqueue("Test P3", 3);
        priorityQueue.Enqueue("Test P4", 4);
        priorityQueue.Enqueue("Test P1_2", 1);
        priorityQueue.Enqueue("Test P2_2", 2);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 1 defect found; For loop was not looping to end and couldn't see last index

        Console.WriteLine("=================");
        
        // Test 4
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 4");

        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("test", 1);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        // Defect(s) Found: 

        Console.WriteLine("=================");
    }
}