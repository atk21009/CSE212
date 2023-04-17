using QueueProblem;


string selection = "";
Queue<Exercise> exercises = new Queue<Exercise>();

while (selection != "3")
{
    Console.WriteLine($"Queue: {string.Join(",", exercises)}");
    Console.WriteLine("Options: ");
    Console.WriteLine("1. Add workout");
    Console.WriteLine("2. Completed a workout");
    Console.WriteLine("3. Quit ");

    selection = Console.ReadLine()!;

    if (selection == "1") {
        Console.WriteLine("Exercise: ");
        string exercise = Console.ReadLine()!;

        Exercise task = new Exercise(exercise);
        exercises.Enqueue(task);
    }
    else if (selection == "2")
    {
        Exercise task = exercises.Dequeue();
        task.CompleteExercise();
    }
    else
    {
        Console.WriteLine("Good job on finishing your workout!");    
    }
}