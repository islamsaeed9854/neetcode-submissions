class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
     int x = 1;
     int zeros = 0;
     for(int i = 0; i < nums.size() ; i++){
        if(nums[i])
        x *= nums[i]; 
        else zeros++;
     }
     vector<int> v;
     for(int i = 0; i < nums.size(); i ++){
        if(zeros > 1)
        v.push_back(0);
        else if(zeros == 1 && nums[i])
        v.push_back(0);
        else if (zeros == 1 && !nums[i] )v.push_back(x);
        else v.push_back(x/nums[i]);
     }
     return v;
    }
};
