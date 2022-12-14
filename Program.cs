using System.Collections.Immutable;
using System.Data.SqlTypes;
using System.Drawing;
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
        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                int min = matrix[i - 1][j];
                if (j - 1 >= 0) min = Math.Min(min, matrix[i - 1][j - 1]);
                if (j + 1 < matrix[0].Length) min = Math.Min(min, matrix[i - 1][j + 1]);
                matrix[i][j] += min;
            }
        }
        return matrix[matrix.Length - 1].Min();
    }
    public bool IsPalindrome(int x)
    {
        if (x == 0)
        {
            return true;
        }
        int remainder, sum = 0;
        int temp = x;

        while (x > 0)
        {
            remainder = x % 10;

            sum = (sum * 10) + remainder;

            x = x / 10;
        }
        if (temp == sum)
        {
            return true;
        }
        else
            return false;



    }
    public int Rob(int[] nums)
    {
        // iterate through array for every other house.
        //Add those numbers together
        //need maximum sum based on numbers in array
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int firstPrevious = 0;
        int secondPrevious = 0;
        int current = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            secondPrevious = firstPrevious;
            firstPrevious = current;
            current = Math.Max(firstPrevious, secondPrevious + nums[i]);
        }

        return current;
    }
    public string LongestCommonPrefix(string[] strs)
    {
        var sizeOfArray = strs.Length;
        if(strs == null || strs.Length == 0)
        {
            return string.Empty;
        }
        Array.Sort(strs);
        int end = Math.Min(strs[0].Length, strs[sizeOfArray - 1].Length);
        int i = 0;
        while (i < end && strs[0][i] == strs[sizeOfArray - 1][i])
            i++;

        string pre = strs[0].Substring(0, i);
        return pre;


    }
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dict = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' },
        };

        foreach (var c in s)
        {
            if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count > 0 && dict[stack.Peek()] != c || stack.Count == 0)
                {
                    return false;
                }

                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }


}
}


