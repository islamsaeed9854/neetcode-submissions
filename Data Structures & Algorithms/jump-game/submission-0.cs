public class Solution {
    public bool CanJump(int[] nums) {
        int cover = 1;
        bool ans = true;
        for(int i = 0; i < nums.Length ;i ++){
            if(cover==0){ans = false;break;}
            cover--; 
            cover = Math.Max(cover , nums[i]);
        }
        return ans;
    }
}
