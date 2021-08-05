public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                maxSum = (sum > maxSum) ? sum : maxSum;
            }
            sum = 0;
        }
        return maxSum;
    }
}