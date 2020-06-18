using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{

    /*
     * Complete the 'dorongString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER dorongKiri
     *  3. INTEGER dorongKanan
     */

    public static int solution(int[] A, int[] B)
    {
        int n = A.Length;
        int m = B.Length;
        Array.Sort(A);
        Array.Sort(B);
        int i = 0;
        for (int k = 0; k < n; k++)
        {
            if (i < m - 1 && B[i] < A[k])
                i++;
            if (A[k] == B[i])
                return A[k];
        }
        return -1;
    }


}
class Solution
{
    public  void Main(string[] args)
    {
        var X = 0;
        var Y = 0;
        int[] A = { 1, 2, 3 };

        solution(X, Y, A);

    }

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
}
