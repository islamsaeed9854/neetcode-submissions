public class Solution {
    public int HammingWeight(uint n) {
        int x = 0;
        while(n>0){
            if((n&1)==1)
            x++;
            n /=2;
        }
        return x;
    }
}
