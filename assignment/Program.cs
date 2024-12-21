using System.ComponentModel;
using System.Drawing;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 :  Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= n; i++) 
            //    Console.Write(i+" ");
            #endregion

            #region q2 :  Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //    Console.Write(i*n+" ");
            #endregion

            #region q3 : Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if(i%2==0) Console.Write(i+" ");
            //}
            #endregion

            #region q4 :  Write a program that takes two integers then prints the power.
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int f = 1;
            //for (int i = 1; i <= m; i++)
            //    f *= n;
            //Console.WriteLine(f);
            #endregion

            #region q5 : Write a program to allow the user to enter a string and print the REVERSE of it.
            //string q=Console.ReadLine();
            //for(int i=q.Length-1;i>=0;i--)
            //  Console.Write(q[i]);
            #endregion

            #region q6 :  Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //for (int i = n; i < m; i++)
            //{
            //    bool prime = false;
            //    for (int j = 2; j < i; j++)
            //    { if (i % j == 0) prime = true; }

            //    if (!prime && i!=1) Console.Write(i+" ");
            //}
            #endregion

            #region q7 :  Write a program in C# Sharp to convert a decimal number into binary without using an array.
            // int n = int.Parse(Console.ReadLine());
            // string q=" ";
            // while (n != 0) {
            //     q += Convert.ToString(n%2);
            //     n /= 2;
            // }
            //for (int i =q.Length-1; i >= 0; i--)
            //     Console.Write(q[i]);
            #endregion

            #region q8 : Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("1 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region q9 : Write C# program that Extract a substring from a given string. 
            //string q=Console.ReadLine();
            //int s = int.Parse(Console.ReadLine());
            //int en= int.Parse(Console.ReadLine());
            //Console.WriteLine(q.Substring(s,en));
            #endregion

            #region q10 : Write C# program that take two string variables and print them as one variable 
            //string q1=Console.ReadLine();
            //string q2=Console.ReadLine();
            //Console.WriteLine(q1+q2);
            #endregion

            #region q11 =q8

            #endregion

            #region q12 :  Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, };
            //int sum = 0;
            //for (int i = 0; i < num.Length; i++) sum += num[i];
            //Console.Write(sum);
            #endregion

            #region q13 :  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            //int[] num = { 1, 2, 3, 4, };
            //int[] num1= { 5,6,7,8};
            //int[] num2=new int [8];
            //int i = 0,j=0,co=0;
            //while (i < num.Length && j < num1.Length)
            //{
            //    if (num[i] < num1[j])
            //    {
            //        num2[co] = num[i]; 
            //        i++;
            //    }
            //    else
            //    {
            //        num2[co] = num1[j];
            //        j++;
            //    }
            //    co++;
            //}
            //while (i < num.Length)
            //{
            //    num2[co] = num[i];
            //    i++;
            //    co++;
            //}

            //while (j < num1.Length)
            //{
            //    num2[co] = num1[j];
            //    j++;
            //    co++;
            //}

            //for(int I=0;I<num2.Length;I++) Console.WriteLine(num2[I]);

            #endregion

            #region q14 : Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int[] frq=new int[20];
            //Array.Clear(frq, 0, frq.Length);

            //for (int i = 0; i < num.Length; i++)
            //{
            //    frq[num[i]]++;
            //}
            //for (int i = 0; i < frq.Length; i++)
            //{
            //    Console.WriteLine(i+" " + frq[i]);
            //}
            #endregion

            #region q15 : Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int mn = 10000;
            //int mx = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    mx=Math.Max(mx, num[i]);
            //    mn=Math.Min(mn, num[i]);
            //}
            //Console.WriteLine($"max = {mx} || min = {mn}");

            #endregion

            #region q16 : Write a program in C# Sharp to find the second largest element in an array.
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //Array.Sort(num);
            //Console.WriteLine(num[num.Length-2]);
            #endregion

        }
    }
}