internal class Program
{
    private static void Main(string[] args)
    {
        Solution test = new Solution();
        Console.WriteLine(test.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
    }
}

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int nonDuplicateAmount = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        continue;
                    }
                    else 
                    {
                    nums[i + 1] = nums[j];
                        i++;
                    }
                }
            }

        foreach (var number in nums)
        {
            Console.WriteLine(number);
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1]) nonDuplicateAmount++;
            else return nonDuplicateAmount;
        }
        return nonDuplicateAmount;
    }
}

