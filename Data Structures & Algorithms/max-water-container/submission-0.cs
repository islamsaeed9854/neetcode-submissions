public class Solution {
    public int MaxArea(int[] heights) {
       int l = 0 , r = heights.Length-1 , mx = -1;
       while(l<r){
        mx = Math.Max(mx, (r - l)   *(Math.Min(heights[l], heights[r])));
        if(heights[l] > heights[r])r--;
        else l++;
       }
       return mx;
    }
}
