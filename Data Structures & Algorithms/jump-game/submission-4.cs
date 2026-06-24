 public class Solution
 {
     bool [] visited = new bool [1003]; 
     bool [] dp= new bool[1003];
     bool solve(int idx, int n,int[] arr)
     {
         if (idx == n - 1) return true;
         if(idx >= n) return false;
         if (visited[idx] == true)
             return dp[idx];
         visited[idx] = true;
         bool ans = false;
         for (int i = 1; i <= arr[idx]; i++)
             ans |= solve(idx + i, n, arr);
         return dp[idx] = ans;
     }
     public bool CanJump(int[] nums)
     {
         return solve(0, nums.Length,nums);
     }
 }