namespace QueueProblem;

public class Exercise
{
    private string _exercise;

    public Exercise(string exercise)
    {
        _exercise = exercise;
    }
    
    override public string ToString() {
        return $"{_exercise}";
    }
    
    public void CompleteExercise() {
        Console.WriteLine($"{this._exercise} has been completed. Nice work!");
    }
}