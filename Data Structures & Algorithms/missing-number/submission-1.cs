public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int cSum = 0;
        int sum = nums.Length * (nums.Length + 1)/2;
        for (int i = 0; i < nums.Length; i++)
        {
            cSum += nums[i];
        }
        return sum - cSum;
    }
}