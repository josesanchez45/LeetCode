using System.Data.SqlTypes;
using System.Numerics;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        List<int> indexs = new List<int>();
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {

                    indexs.Add(i);
                    indexs.Add(j);



                }
            }
        }
        return indexs.ToArray();


    }


    public int ClimbStairs(int n)
    {
        if (n <= 1)
            return n;
        int[] countWays = new int[n + 1];
        countWays[1] = 1;
        countWays[2] = 2;
        for (int i = 3; i <= n; i++)
        {
            countWays[i] = countWays[i - 1] + countWays[i - 2];
        }
        return countWays[n];
    }
    public int MinFallingPathSum(int[][] matrix)
    {
        for(int i = 1; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                int min = matrix[i - 1][j];
                if (j - 1 >= 0) min = Math.Min(min, matrix[i - 1][j - 1]);
                if(j+1 < matrix[0].Length) min = Math.Min(min,matrix[i-1][j+1]);
                matrix[i][j] += min;
            }
        }
        return matrix[matrix.Length - 1].Min();
    }
    public bool IsPalindrome(int x)
    {
        if( x == 0)
        {
            return false;   
        }
        int remainder, sum = 0;
        int temp = x;

        while(x > 0)
        {
            remainder = x % 10;

            sum =(sum*10) + remainder;

            x = x /10;
        }
        if (temp == sum)
        {
            return true;
        }
        else
            return false;



    }
}


