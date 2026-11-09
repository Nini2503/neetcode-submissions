public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row=findRow(target,matrix);
        if(row>=0)
            return BinarySearch(matrix[row],target);
        return false;
    }
    int findRow(int target, int[][] matrix)
    {
        int low=0;
        int n=matrix[0].Length-1;
        int high=matrix.Length-1;
        while(low<=high)
        {
            int mid=(low+high)/2;
            if(target>=matrix[mid][0]&& target<=matrix[mid][n])
                return mid;
            else if(target<matrix[mid][0])
                high=mid-1;
            else 
                low=mid+1;
        }
        return -1;
    }
    bool BinarySearch(int[] nums, int target)
    {
        int low=0;
        int high=nums.Length-1;
        while(low<=high)
        {
            int mid=(low+high)/2;
            
            if(target==nums[mid])
                return true;
            if(target>nums[mid])
                low=mid+1;
            else
                high=mid-1;
        }
        return false;
    }
}
