using System;
public class Armstrong
{
    public int solution(int X, int Y, int[] A)
    {
        int N = A.Length;
        int result = -1;
        int nX = 0;
        int nY = 0;
        for (int i = 0; i < N; i++)
        {
            if (A[i] == X)
                nX += 1;
            else if (A[i] == Y)
                nY += 1;
            if (nX == nY)
                result = i;
        }
        return result;
    }
    public void Main(string[] args)
    {
        var X= 0;
        var Y = 0;
        int[] A = { 1, 2, 3 };


        solution(X, Y, A);
    }
}