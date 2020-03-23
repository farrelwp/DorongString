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


    public static string dorongString(string s, int dorongKiri, int dorongKanan)
    {
        int strlen = s.Length;

        try
        {
            Console.WriteLine("Jumlah String = " + strlen);

            if (strlen == 1)
            {
                s = s;
            }
            else
            {
                for (int i = 0; i < dorongKiri; i++)
                {
                    Console.WriteLine("Dorong Kiri ke - " + i + " = " + s);
                    //dorong kiri
                    if (s.Substring(0, 3) == "XYZ")
                    {

                        var a1 = s.Substring(3, strlen - 3);
                        var a2 = s.Substring(0, 3);
                        s = a1 + a2;

                    }
                    else
                    {
                        var a1 = s.Substring(1, strlen - 1);
                        var a2 = s.Substring(0, 1);
                        s = a1 + a2;

                    }
                }
                for (int i = 0; i < dorongKanan; i++)
                {
                    Console.WriteLine("Dorong Kanan ke - " + i + " = " + s);
                    //dorong kanan
                    if (s.Substring(strlen - 3, 3) == "XYZ")
                    {
                        var a1 = s.Substring(strlen - 3, 3);
                        var a2 = s.Substring(0, strlen - 3);
                        s = a1 + a2;
                    }
                    else
                    {
                        var a1 = s.Substring(strlen - 1, 1);
                        var a2 = s.Substring(0, strlen - 1);
                        s = a1 + a2;
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Hasil Akhir = " + s);
        Console.WriteLine("Hasil Akhir Jumlah string = " + s.Length);
        return s;
    }

}
class Solution
{
    public static void Main(string[] args)
    {


        string s = Console.ReadLine();

        int dorongKiri = Convert.ToInt32(Console.ReadLine().Trim());

        int dorongKanan = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dorongString(s, dorongKiri, dorongKanan);
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);


        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
