using System;
namespace Working_With_Array
{
    class array
    {


        public static void Main(string[] args)
        {
            int sum = 0;
            int[] num = new int[5];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;


            foreach(int i in num)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sum of all element in an array:" + sum);

        }


    }


}
    
   