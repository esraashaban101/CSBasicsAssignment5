using System.ComponentModel;
using System.Threading.Channels;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            int n = int.Parse(Console.ReadLine());
            int[,] identity = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1 - i)
                    {
                        identity[i, j] = 1;

                    }
                    else
                    {
                        identity[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(identity[i, j]);

                }
                Console.WriteLine();
            }
            #endregion

            #region 2-	Write a program in C# Sharp to find the sum of all elements of the array.
            int size = int.Parse(Console.ReadLine());
            int[] sumArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                int.TryParse(Console.ReadLine(), out sumArray[i]);
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += sumArray[i];
            }
            Console.WriteLine(sum);
            #endregion

            #region 3-	- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            int length = int.Parse(Console.ReadLine());


            int[] arr1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr1[i]);
            }
            int[] arr2 = new int[length];
            for (int i = 0; i < length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr2[i]);
            }
            int[] arr3 = new int[2 * length];
            for (int i = 0; i < length; i++)
            {

                arr3[i] = arr1[i];

            }
            for (int i = length; i < 2 * length; i++)
            {

                arr3[i] = arr2[i - length];

            }
            Array.Sort(arr3);
            for (int i = 0; i < 2 * length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            #endregion

            #region 4-	 Write a program in C# Sharp to count the frequency of each element of an array.

            int lengthofcounted = int.Parse(Console.ReadLine());
            int[] counted = new int[lengthofcounted];
            int[] freq = new int[lengthofcounted];
            for (int i = 0; i < counted.Length; i++)
            {
                counted[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(counted);


            for (int i = 0; i < counted.Length; i++)
            {

                freq[counted[i]]++;


            }
            for (int i = 0; i < counted.Length; i++)
            {
                Console.WriteLine(freq[counted[i]]);
            }

            #endregion

            #region  5 - Write a program in C# Sharp to find maximum and minimum element in an array

            int maxminsize = int.Parse(Console.ReadLine());
            int[] arr = new int[maxminsize];
            int maxVal = 0, minval = 100000000;
            for (int i = 0; i < arr.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                maxVal = Math.Max(arr[i], maxVal);
                minval = Math.Min(arr[i], minval);

            }
            Console.WriteLine($"Max = {maxVal} ");
            Console.WriteLine($"Min = {minval}");
            #endregion

            #region   6 - Write a program in C# Sharp to find the second largest element in an array.

            int len = int.Parse(Console.ReadLine());

            int[] secMaxVal = new int[len];
            for (int i = 0; i < secMaxVal.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out secMaxVal[i]);
            }
            if (len == 1)
            {
                Console.WriteLine($"second largest value is {secMaxVal[0]}");
            }
            else
            {
                Array.Sort(secMaxVal);
                Console.WriteLine($"second largest value is {secMaxVal[len - 2]}");

            }

            #endregion

            #region 7-write a program to find the longest distance between Two equal cells.
            int sizzze = int.Parse(Console.ReadLine());

            int [] longest = new int[sizzze];
            for (int i = 0; i < longest.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out longest[i]);
            }
            int maxdistance = 0;
            for (int i = 0; i < longest.Length; i++)
            {
                for (int j = 0; j < longest.Length; j++)
                {
                    if(longest[i] == longest[j])
                    {
                        maxdistance = Math.Max(maxdistance, Math.Abs(i-j));
                    }
                }

            }
            Console.WriteLine(maxdistance - 1);
            #endregion
            #region 8-No Question

            #endregion
            #region 9-	Given a list of space separated words, reverse the order of the words

            string phrase = Console.ReadLine();
            string[] word = phrase.Split(' ');



            Array.Reverse(word);
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
            #endregion
            #region 10-	 Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            int nn = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] first = new int[nn, m];
            int[,] second = new int[nn, m];
            for (int i = 0; i < nn; i++)

            {
                for (int j = 0; j < m; j++)
                {
                    first[i, j] = int.Parse(Console.ReadLine());
                    second[i, j] = first[i, j];
                }
            }

            for (int i = 0; i < nn; i++)

            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(second[i, j]);

                }
                Console.WriteLine();
            }
            #endregion
            #region 11-	Write a Program to Print One Dimensional Array in Reverse Order

            int len2 = int.Parse(Console.ReadLine());

            int[] reversedArray = new int[len2];
            for (int i = 0; i < reversedArray.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out reversedArray[i]);
            }
            Array.Reverse(reversedArray);
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.WriteLine(reversedArray[i]);
            }
        }

        #endregion
    }

}










