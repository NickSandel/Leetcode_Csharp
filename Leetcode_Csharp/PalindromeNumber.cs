namespace Leetcode_Csharp;

public class PalindromeNumber
{
    public bool Process(int x)
    {
        // Turn the int into a string and check it's reverse
        var c = x.ToString().ToCharArray();
        Array.Reverse(c);
        return x.ToString() == new string(c);
    }
}
