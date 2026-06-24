class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
        unordered_map<int,int> found, visited;
        int ans = 0;
        for(int i = 0; i< nums.size() ;i++){
           found[nums[i]] = 1;
        }
        for(int i = 0; i < nums.size();i++){
            int cur = 1, curElm = nums[i]-1;
            while(! visited[curElm]&& found[curElm]){
                visited[curElm]=1;
                curElm -- ;
                cur ++;
            }
            curElm = nums[i]+1;
             while(!visited[curElm]&&found[curElm]){
                visited[curElm]=1;
                curElm ++;
                cur ++;
            }
            ans = max(ans, cur);
        }
        return ans;
    }
};



