using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region loop
            //Console.WriteLine(1); 
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //for (int i = 0; i <=10; i++) Console.WriteLine(i);
            #endregion

            #region for each
            //int[] num = {1,2,3,4,5};
            //    foreach (int i in num)
            //{
            //    i+=10 //invaled
            //        Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 10; i++) { 
            //    if(i==5)break;
            //    Console.WriteLine(i);
            //}
            #endregion

            #region  while ,do while
            //int num;
            bool flag= true;
            //do 
            //{
            //    Console.WriteLine("enter");
            //    //num=int.Parse(Console.ReadLine());
            //    flag=int.TryParse(Console.ReadLine(), out num); //cheack if i can parse it
            //}while (num%2==1 || flag==false);

            //Console.WriteLine("num is even");

            //int num = 3;
            //while (num % 2 == 1 || flag == false)
            //{
            //    Console.WriteLine("enter");
            //    flag = int.TryParse(Console.ReadLine(), out num);

            //}
            #endregion


            #region string
            //immutable
            //at=rray char
            // have same hash if contain same value
            #endregion

            #region string builder

            //StringBuilder sb = new StringBuilder(" ");
            //sb.AppendLine("no");
            //sb.AppendLine("mo");
            //sb.Remove(1, 1);
            //sb.AppendFormat();

            #endregion

            #region  array 1d
            //int[] num = {1,2,3};
            //for (int i = 0; i < num.Length; i++)
            //    Console.WriteLine(num[i]);

            #endregion

            #region  array 2d
            //int[,] num =new int[3][4];

            #endregion

            #region  judged array
            int[][] num = new int[3][];
            num[0]=new int[3];
            num[1] = new int[2];
            num[2] = new int[1];
            for(int i = 0; i < num.Length; i++)
                for(int j = 0; j < num[i].Length; j++)
                    Console.WriteLine(num[i][j]);
            #endregion


        }
    }
}
