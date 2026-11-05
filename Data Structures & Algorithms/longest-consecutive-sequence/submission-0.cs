public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0)
            return 0;
        Array.Sort(nums);
        int longest=1;
        int count=1;
        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i-1]+1==nums[i])
                count++;
            else if(nums[i-1]==nums[i])
                continue;
            else
                count=1;
            longest=Math.Max(longest,count);
        }
        return longest;
    }
}
