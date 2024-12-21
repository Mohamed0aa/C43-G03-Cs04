namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 :  Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) 
                Console.Write(i+" ");
            #endregion

            
        }
    }
}
