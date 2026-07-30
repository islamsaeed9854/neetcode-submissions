public class Solution {
    public int[] CountBits(int n) {
        int[] res = new int[n + 1];

        for (int i = 1; i <= n; i++) {
            int temp = i;
            while (temp > 0) {
                res[i]++;
                temp = temp & (temp - 1);
            }
        }
        return res;
    }
}