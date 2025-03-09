using Leetcode_Csharp;

namespace Leetcode_Csharp_Test;

public class TestIntegerToRoman
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(4, "IV")]
    [InlineData(6, "VI")]
    [InlineData(66, "LXVI")]
    [InlineData(3749, "MMMDCCXLIX")]
    [InlineData(3000, "MMM")]
    [InlineData(300, "CCC")]
    [InlineData(900, "CM")]
    [InlineData(700, "DCC")]
    [InlineData(750, "DCCL")]
    [InlineData(740, "DCCXL")]
    public void TestIntegerToRoman_VariousExamples(int s, string expectedOutput)
    {
        IntegerToRoman integerToRoman = new IntegerToRoman();

        var output = integerToRoman.Process(s);

        Assert.Equal(expectedOutput, output);
    }
}
