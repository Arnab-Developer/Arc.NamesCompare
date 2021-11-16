using System;
using System.Collections.Generic;
using System.Linq;

namespace Arc.NamesCompareTest;

public class CompareTest
{
    [Fact]
    public void Can_GetComparisonResult_ReturnProperResult()
    {
        IEnumerable<string> nameList1 = new List<string> { "Name1", "Name2", "Name3", "Name4" };
        IEnumerable<string> nameList2 = new List<string> { "Name1", "Name3", "Name5" };

        ComparisonResult result = Compare.GetComparisonResult(nameList1, nameList2);

        Assert.Equal(2, result.CommonNames.Count());
        Assert.Contains("Name1", result.CommonNames);
        Assert.Contains("Name3", result.CommonNames);

        Assert.Equal(2, result.UniqueList1Names.Count());
        Assert.Contains("Name2", result.UniqueList1Names);
        Assert.Contains("Name4", result.UniqueList1Names);

        Assert.Single(result.UniqueList2Names);
        Assert.Contains("Name5", result.UniqueList2Names);
    }

    [Fact]
    public void Can_GetComparisonResult_ThrowException()
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        Assert.Throws<ArgumentNullException>(() => Compare.GetComparisonResult(null, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    }

    [Fact]
    public void Can_GetComparisonResult_ThrowExceptionWithNameList1Null()
    {
        IEnumerable<string> nameList2 = new List<string> { "Name1", "Name3", "Name5" };

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        Assert.Throws<ArgumentNullException>(() => Compare.GetComparisonResult(null, nameList2));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    }

    [Fact]
    public void Can_GetComparisonResult_ThrowExceptionWithNameList2Null()
    {
        IEnumerable<string> nameList1 = new List<string> { "Name1", "Name2", "Name3", "Name4" };

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        Assert.Throws<ArgumentNullException>(() => Compare.GetComparisonResult(nameList1, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    }
}