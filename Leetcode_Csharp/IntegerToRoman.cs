namespace Leetcode_Csharp;

public class IntegerToRoman
{
    public string Process(int num)
    {
        // Best method to mind is to step through each digit and generate 
        // the string that way
        // Brief says it will never exceed 3999 so only dealing with 4 digits
        string numString = num.ToString();
        // 0 pad so the character expectation is met
        numString = numString.PadLeft(4, '0');
        char[] chars = numString.ToCharArray();
        string output = "";
        //First one is easy it's just the thousands in num to repeat M
        output += String.Concat(Enumerable.Repeat("M", int.Parse(chars[0].ToString())));
        int hundreds = int.Parse(chars[1].ToString());
        switch (hundreds)
        {
            case int h when h > 0 && h < 4:
                output += String.Concat(Enumerable.Repeat("C", hundreds));
                break;
            case 4:
                output += "CD";
                break;
            case 5:
                output += "D";
                break;
            case 9:
                output += "CM";
                break;
            case int h when h > 5 && h < 9:
                output += "D" + String.Concat(Enumerable.Repeat("C", hundreds - 5));
                break;
        }
        int tens = int.Parse(chars[2].ToString());
        switch (tens)
        {
            case int h when h > 0 && h < 4:
                output += String.Concat(Enumerable.Repeat("X", tens));
                break;
            case 4:
                output += "XL";
                break;
            case 5:
                output += "L";
                break;
            case 9:
                output += "XC";
                break;
            case int h when h > 5 && h < 9:
                output += "L" + String.Concat(Enumerable.Repeat("X", tens - 5));
                break;
        }
        int ones = int.Parse(chars[3].ToString());
        switch (ones)
        {
            case int h when h > 0 && h < 4:
                output += String.Concat(Enumerable.Repeat("I", ones));
                break;
            case 4:
                output += "IV";
                break;
            case 5:
                output += "V";
                break;
            case 9:
                output += "IX";
                break;
            case int h when h > 5 && h < 9:
                output += "V" + String.Concat(Enumerable.Repeat("I", ones - 5));
                break;
        }
        return output;
    }
}
