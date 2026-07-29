public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, bool> map = new Dictionary<char, bool>();
        int l = 0,mx = 0;
        for (int i = 0; i < s.Length; i++)
        {
            while (map.ContainsKey(s[i]) && map[s[i]] == true)
            {
                map[s[l++]] = false;
            }
            map[s[i]] = true;
            mx = Math.Max (mx, i-l+1);
        }
        return mx;
    }
}