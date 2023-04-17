namespace prove_06;

public static class DictionaryExtensionMethods {
    public static string AsString(this System.Collections.IEnumerable dictionary) {
        return "<Dictionary>{" + string.Join(", ", (Dictionary<string, int>)dictionary) + "}";
    }
}