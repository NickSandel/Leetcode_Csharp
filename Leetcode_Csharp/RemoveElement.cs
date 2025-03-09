using System.Linq;
namespace Leetcode_Csharp;

public class RemoveElement
{
    public int Process(int[] nums, int val)
    {
        //As the problem states 0 <= val <= 100 can use 101 as a magic number to replace
        int magicNumber = 101;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                nums[i] = magicNumber;
            }
        }
        Array.Sort(nums);
        return nums.Count(x => x != magicNumber);
    }
}
