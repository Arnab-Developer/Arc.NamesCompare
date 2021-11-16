namespace Arc.NamesCompare;

/// <summary>
/// Compare two list of names.
/// </summary>
public static class Compare
{
    /// <summary>
    /// Compare two list of names.
    /// </summary>
    /// <param name="nameList1">Name list 1</param>
    /// <param name="nameList2">Name list 2</param>
    /// <returns>Comparison result</returns>
    public static ComparisonResult GetComparisonResult(IEnumerable<string> nameList1,
        IEnumerable<string> nameList2)
    {
        ArgumentNullException.ThrowIfNull(nameList1);
        ArgumentNullException.ThrowIfNull(nameList2);

        IEnumerable<string> commonNames = nameList1.Intersect(nameList2);
        IEnumerable<string> uniqueList1Names = nameList1.Except(nameList2);
        IEnumerable<string> uniqueList2Names = nameList2.Except(nameList1);

        ComparisonResult comparisonResult = new(commonNames, uniqueList1Names, uniqueList2Names);

        return comparisonResult;
    }
}