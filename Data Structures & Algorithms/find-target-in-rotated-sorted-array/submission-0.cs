public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0 , r = nums.Length-1;
        while(l <= r){
             int mid = (l+r)/2;
             if(nums[mid] == target){
                return mid;
             }
             else if( nums[nums.Length-1] > nums[mid]){
                 if(target >= nums[mid] && target <= nums[nums.Length-1])
                   l = mid + 1;
                else r = mid - 1;
             }
             else{
  if(target <= nums[mid] && target >= nums[0])
                   r = mid - 1;
                else l = mid + 1;
             }
        }
        return -1;
    }
}
