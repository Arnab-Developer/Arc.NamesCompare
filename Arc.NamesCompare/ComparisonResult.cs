namespace Arc.NamesCompare;

/// <summary>
/// Comparison result
/// </summary>
/// <param name="CommonNames">Common names between two name lists</param>
/// <param name="UniqueList1Names">Names which are in list 1 but not in list 2</param>
/// <param name="UniqueList2Names">Names which are in list 2 but not in list 1</param>
public record ComparisonResult(IEnumerable<string> CommonNames, IEnumerable<string> UniqueList1Names,
    IEnumerable<string> UniqueList2Names);