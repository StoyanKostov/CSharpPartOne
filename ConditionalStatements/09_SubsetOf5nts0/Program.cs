using System;

class SubsetOf5nts0
{
    static void Main()
    {
        /// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
        Console.WriteLine("We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.");
        
        


        // Input
        int[] arr = new int[5];
        int sum = 0;
        for (int i = 0; i < 5; i++) 
        {
            Console.Write("Enter integer " + (i+1) + ": ");
            sum += int.Parse(Console.ReadLine());
            arr[i] = sum;
        }

        bool result = false;

        //Main Logic
        if (sum == 0)
        {
            result = true;
        }
        else 
        {
            for (int j = 0; j < arr.Length; j++)
            {

                if (sum + arr[j] == 0)
                {
                    result = true;
                    break;
                }
                //else
                //{
                //    
                //   //int sum1 = sum - arr[i];
                //   //for (int j = i + 1; j < arr.Length; j++)
                //   //{
                //   //    if (sum1 - arr[j] == 0)
                //   //    {
                //   //        result = true;
                //   //        break;
                //   //    }
                //   //}
                //}
            }
            result = false;
        }

        Console.WriteLine("the sum is {0} of some subset of them is = {1}", sum, result);
    }
}