using Leetcode_Csharp;

namespace Leetcode_Csharp_Test;

public class TestTwoSum
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TestTwoSum_VariousExamples(int[] nums, int target, int[] expectedOutput)
    {
        TwoSum twoSum = new TwoSum();

        var output = twoSum.Process(nums, target);

        Assert.Equal(expectedOutput, output);
    }
}
