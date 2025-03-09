using System;
namespace Leetcode_Csharp;

public class TwoSum
{
    public int[] Process(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int ii = 0; ii < nums.Length; ii++)
            {
                if (i != ii && nums[i] + nums[ii] == target)
                {
                    return new int[] { i, ii };
                }
            }
        }
        return new int[0];
    }
}
