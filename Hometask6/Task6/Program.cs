using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace HomeTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emails = { "Aydanshj@code.edu.az, Kubramdva@code.az, Jeyhun@code.com " };
            var result1 = DomainGmail(emails);
            for (int i = 0; i < result1.Length; i++)
            {
                Console.WriteLine((result1[i]));
            }

            string text = " Hello Amazing World ";
            Console.WriteLine(IsDigit(text));

            Console.WriteLine(IsName("Aidan"));

            string text2 = " Hello. Start a new day. It will be amazing day";
            var result4 = CountOfSent(text2);
            Console.WriteLine(result4);

            int[] arr1 = { 3, 6, 7, 8, 11, 39 };
            var result = DifArray(arr1);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine((result[i]));
            }
        }
        static string[] DomainGmail(string[] emails)
        {
            for (int i = 0; i < emails.Length; i++)
            {
                emails[i] = emails[i].Substring(emails[i].IndexOf('@') + 1);
            }
            var result = new string[0];
            for (int i = 0; i < emails.Length; i++)
            {
                if (Array.IndexOf(result, emails[i]) == -1)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = emails[i];
                }
            }
            return result;

        }
        static bool hasDigit(string text)
        {
            int[] digit = { '0', '1', '3', '4', '5', '6', '7' };

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < digit.Length; j++)
                {
                    if (text[i] == digit[j])
                    {
                        return true;
                    }
                }
            }
            return false;


        }
        static bool FullName(string str)
        {
            str = str.Trim();
            var arr = str.Split(' ');
            if (IsName(arr[0]) && IsName(arr[1]))
            {
                return true;
            }
            return false;
        }
         static int CountOfSent(string text2)
         {
            int count = 0;

            for(int i = 0; i < text2.Length; i++)
            {
                if (text2[i] == '.' || text2[i] == '!' || text2[i] == '?')
                {
                    count++;
                }
            }
            return count;
         }
        static int[] DifArray(int[] arr)
        {
            int[] newArray = new int [0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArray, arr[i]) == -1)
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    newArray[newArray.Length - 1] = arr[i];
                }
            }
            return newArray;
        }
    }
}
