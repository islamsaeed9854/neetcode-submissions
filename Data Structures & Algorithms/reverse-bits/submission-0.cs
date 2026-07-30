public class Solution
{
    public uint ReverseBits(uint n)
    {
        uint res = 0;
        for(int i = 0; i< 32; i++)
        {
            if( (n & (1 << i))>0)
            {
                res |= (uint)(1<<(32-i-1));
            }
        }
        return res;
    }
}