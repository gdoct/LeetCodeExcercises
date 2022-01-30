namespace LeetCode.Impl.TwoSum;

internal class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int x = 0;
        for (int col = 0; col < nums.Length; col++)
        {
            int i = nums[col];
            int y = 0;
            for (int n = 0; n < nums.Length; n++)
            {
                int j = nums[n];
                if (x == y) continue;
                if (i + j == target)
                {
                    return new[] { x, y };
                }
                y++;
            }
            x++;
        }
        // not found!
        return new[] { -1, -1 };
    }
}
