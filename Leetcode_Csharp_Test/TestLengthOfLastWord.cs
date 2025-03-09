using Leetcode_Csharp;

namespace Leetcode_Csharp_Test;

public class TestLengthOfLastWord
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void TestLengthOfLastWord_VariousExamples(string s, int expectedOutput)
    {
        LengthOfLastWord lengthOfLastWord = new LengthOfLastWord();

        var output = lengthOfLastWord.Process(s);

        Assert.Equal(expectedOutput, output);
    }
}
