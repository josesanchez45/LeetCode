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
        for (int i = 3; i <=  n ; i++)
        {
            countWays[i] = countWays[i - 1] + countWays[i - 2];
        }
        return countWays[n];
    }

}

