using System.Text;

namespace prove_06;

public class DataCollection
{
    public String Place { get; set; }
    public Decimal Mag { get; set; }
}

public class PropertiesCollection
{
    public DataCollection Properties { get; set; }
}


public class FeatureCollection {
    // Todo Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public PropertiesCollection[] Features { get; set; }
}






