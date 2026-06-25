class Solution {
public:
    int characterReplacement(string s, int k) {
        unordered_map<char ,int> mp;
        int left = 0 , right = 0 , best_ans = 0;
        char most_repeat_now = s[0];
        for(;right < s.size() ; right++){
            mp[s[right]]++;
            if(mp[s[right]] >= mp[most_repeat_now]){
                most_repeat_now = s[right];
            }
            int cur_need = (right - left + 1) - mp[most_repeat_now];
            while(cur_need > k){
              mp[s[left++]]--;
              if(mp[s[right]] > mp[most_repeat_now]){
                most_repeat_now = s[right];
                }
              cur_need = (right - left + 1) - mp[most_repeat_now];
            } 
            best_ans = max(best_ans , right - left + 1);
        }
        return best_ans;
    }
};
