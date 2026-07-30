public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new Stack<char>();
        Dictionary<char, char> dic = new Dictionary<char, char>();
        dic['['] = ']';
        dic['('] = ')';
        dic['{'] = '}';
        foreach (char c in s) {
            if (stk.Count >= 1) {
                char temp = stk.Pop();
                if (dic.ContainsKey(temp) && c == dic[temp]) {
                } else {
                    stk.Push(temp);
                    stk.Push(c);
                }
            } else
                stk.Push(c);
        }
        return stk.Count == 0;
    }
}