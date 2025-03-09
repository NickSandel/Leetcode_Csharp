using Leetcode_Csharp;

namespace Leetcode_Csharp_Test;

public class TestPalindromeNumber
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void TestPalindromeNumber_VariousExamples(int x, bool expectedOutput)
    {
        PalindromeNumber palindromeNumber = new PalindromeNumber();

        var output = palindromeNumber.Process(x);

        Assert.Equal(expectedOutput, output);
    }
}
