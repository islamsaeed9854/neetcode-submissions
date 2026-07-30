public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int assumed = 0;
        for(int i = 0 ; i <= nums.Length; i++)
        {
            assumed ^= i;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            assumed ^= nums[i];
        }
        return assumed;
    }
}