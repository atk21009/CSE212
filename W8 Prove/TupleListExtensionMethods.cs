using System.Collections;

namespace prove_08;

public static class TupleListExtensionMethods {
    public static string AsString(this IEnumerable list) {
        return "<List>{" + string.Join(", ", list.Cast<ValueTuple<int, int>>()) + "}";
    }
}