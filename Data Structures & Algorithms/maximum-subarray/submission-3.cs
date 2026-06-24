public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = nums[0]>=0 ? nums[0]:0, max_ans = nums[0];
        for(int i = 1; i < nums.Length ; i++){
            sum += nums[i]; 
            if(sum > 0)max_ans = Math.Max(max_ans , sum);
            else { max_ans = Math.Max(max_ans , sum);sum = 0;}
        }
        return max_ans;
    }
}
