namespace QueueExample;

public class HairCut {
    private string _fName;
    private string _lName;

    public HairCut(string fName, string lName) {
        _fName = fName;
        _lName = lName;
    }

    public override string ToString() {
        return $"{_fName} {_lName}";
    }
    

    public void ServeCustomer() {
        Console.WriteLine($"{this._fName} {this._lName} has received a hair cut");
    }
    
}