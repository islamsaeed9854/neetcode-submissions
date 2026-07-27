class Solution {
public:
    bool isPalindrome(string s) {

        int l = 0 , r = s.size()-1;
        while(l < r){
            while(l < r && ( (tolower(s[l]) <'a' || tolower(s[l]) > 'z') && (tolower(s[l]) <'0' || tolower(s[l]) > '9') ))l++;
            while(l < r && ( (tolower(s[r]) <'a' || tolower(s[r]) > 'z') && (tolower(s[r]) <'0' || tolower(s[r]) > '9') ))r--;
            if(tolower(s[l]) != tolower(s[r]))return false;
            l++,r--;
        }
        return true;
    }
};
