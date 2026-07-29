public class Solution
{
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> mapT = new Dictionary<char, int>();
        Dictionary<char, int> mapS = new Dictionary<char, int>();
        Dictionary<int, int> gave = new Dictionary<int, int>();
        for (char i = 'a'; i <= 'z'; i++)
        {
            mapS[i] = 0;
            mapT[i] = 0;
        }
        for (char i = 'A'; i <= 'Z'; i++)
        {
            mapS[i] = 0;
            mapT[i] = 0;
        }
        for (int i = 0; i < t.Length; i++)
        {
            mapT[t[i]]++;
        }
        int l = 0, mn = 10000000, have = 0, Tsize = t.Length, bestLeft = -1, bestRight = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (mapT[s[i]] > mapS[s[i]])
            {
                mapS[s[i]]++;
                gave[i] = 1;
                have++;
            }
            else mapS[s[i]]++;
            while (l < s.Length  && mapS[s[l]] > mapT[s[l]])
            {
                mapS[s[l]]--;
                l++;
            }
            if (have == Tsize)
            {
                if (mn > i - l + 1)
                {
                    mn = i - l + 1;
                    bestLeft = l;
                    bestRight = i;
                }
            }
        }

        if (bestLeft != -1)
        {
            return s.Substring(bestLeft, bestRight - bestLeft + 1);
        }
        else return "";
    }
}
