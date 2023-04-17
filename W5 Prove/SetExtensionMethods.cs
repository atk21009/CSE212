namespace prove_05;

public static class SetExtensionMethods {
    public static string AsString(this System.Collections.IEnumerable set) {
        return "<Set>{" + string.Join(", ", (HashSet<int>)set) + "}";
    }
}