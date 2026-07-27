public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> ans = new List<List<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length-2; i++)
        {
            int l = i + 1 , r = nums.Length-1;
            if (i>0&&nums[i] == nums[i - 1])
                continue;
            while (l < r)
            {
                if (nums[l] + nums[r] > -nums[i]) r--;
                else if (nums[l] + nums[r] < -nums[i]) l++;
                else
                {
                    ans.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    r--;

                    while (l < r && nums[l] == nums[l - 1])
                        l++;

                    while (l < r && nums[r] == nums[r + 1])
                        r--;
                }

            }
        }
        return ans;
    }
}