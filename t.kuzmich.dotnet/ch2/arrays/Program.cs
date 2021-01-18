using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = new string[4];
            nums[0] = "0";
            nums[1] = "1";
            nums[2] = "2";
            nums[3] = "3";
            foreach (string item in nums)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
