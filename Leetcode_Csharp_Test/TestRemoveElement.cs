using Leetcode_Csharp;

namespace Leetcode_Csharp_Test;

public class TestRemoveElement
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 })]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 0, 1, 3, 4 })]
    public void TestRemoveElement_VariousExamples(int[] nums, int val, int expectedVal, int[] expectedOutput)
    {
        RemoveElement removeElement = new RemoveElement();

        var output = removeElement.Process(nums, val);

        Assert.Equal(expectedVal, output);

        for (int i = 0; i < output; i++)
        {
            Assert.Equal(nums[i], expectedOutput[i]);
        }
    }
}
