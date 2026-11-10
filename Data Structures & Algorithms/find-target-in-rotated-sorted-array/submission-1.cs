public class Solution {
    public int Search(int[] nums, int target) {
        int low=0,high=nums.Length-1;
        while(low<high)
        {
            int mid=(low+high)/2;
            if(nums[mid]<nums[high])
                high=mid;
            else
                low=mid+1;
        }
        int pivot=low;
        int res=BinarySearch(target,nums,0,pivot-1);
        if(res!=-1)
            return res;
        return BinarySearch(target,nums,pivot,nums.Length-1);
    }
    int BinarySearch(int target, int[] nums, int low, int high)
    {
        while(low<=high)
        {
            int mid=(low+high)/2;
            Console.WriteLine(nums[mid]);
            if(target==nums[mid])
                return mid;
            if(target>nums[mid])
                low=mid+1;
            else
                high=mid-1;
        }
        return -1;
    }
}
