 public class Solution
 {
     public struct val
     {
         public int r, c, dirN;
         public val(int r, int c, int dirN)
         {
             this.r = r;
             this.c = c;
             this.dirN = dirN;
         }
     }
     public val GetNextPoint(int r, int c, int dirN, int size, int I)
     {
         if (dirN == 0)
         {
             if (r - I + 1 >= size)
                 return new val(r, c + 1, 1);
             else return new val(r + 1, c, dirN);
         }
         else if (dirN == 1)
         {
             if (c - I + 1 >= size)
                 return new val(r - 1, c, 2);
             else return new val(r, c + 1, dirN);
         }
         else if (dirN == 2)
         {
             if (r - I - 1 < 0)
                 return new val(r, c - 1, 3);
             else return new val(r - 1, c, dirN);
         }
         else
         {
             if (c - I - 1 < 0)
                 return new val(r + 1, c, 0);
             else return new val(r, c - 1, dirN);
         }
     }

     public val ToSwap(int r, int c, int dirN, int size, int I, int shift)
     {
         int curR = r, curC = c, curDirN = dirN;
         for (int i = 0; i < shift; i++)
         {
             val ret = GetNextPoint(curR, curC, curDirN, size, I);
             curR = ret.r; curC = ret.c; curDirN = ret.dirN;
         }
         return new val(curR, curC, curDirN);
     }
     public void Rotate(int[][] matrix)
     {
         int size = matrix[0].Length;

         for (int I = 0; I < matrix[0].Length / 2; I++)
         {
             int shift = size - 1;
             int CurR = I, CurC = I;
             int shiftTimes = size + (size - 1) + (size - 1) + (size - 2) - shift;
             int CurD = 0;
             for (int i = 0; i < shiftTimes; i++)
             {
                 val NextPoint = GetNextPoint(CurR, CurC, CurD, size, I);
                 val nextSwap = ToSwap(CurR, CurC, CurD, size, I, shift);
                 (matrix[CurR][CurC], matrix[nextSwap.r][nextSwap.c]) = (matrix[nextSwap.r][nextSwap.c], matrix[CurR][CurC]);
                 CurD = NextPoint.dirN;
                 CurR = NextPoint.r;
                 CurC = NextPoint.c;
             }
             size -= 2;
         }

     }
 }