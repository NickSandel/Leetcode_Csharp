namespace Leetcode_Csharp;

public class LengthOfLastWord
{
    public int Process(string sentence)
    {
        sentence = sentence.Trim();
        string[] words = sentence.Split(' ');
        return words[words.Length - 1].Length;
    }
}
