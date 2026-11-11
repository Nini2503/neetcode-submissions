public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        if(nums1.Length>nums2.Length)
            return FindMedianSortedArrays(nums2,nums1);
        
        int low=0;
        int high=nums1.Length;

        while(low<=high)
        {
            int partitionX=(low+high)/2;
            //partitionX+PartitionY= (nums1.Length+nums2.Length+1)/2

            int partitionY=(nums1.Length+nums2.Length+1)/2 - partitionX;

            int maxLeftX=(partitionX==0)? int.MinValue : nums1[partitionX-1];
            int maxLeftY=(partitionY==0)? int.MinValue : nums2[partitionY-1];

            int minRightX=(partitionX==nums1.Length)? int.MaxValue : nums1[partitionX];
            int minRightY=(partitionY==nums2.Length)? int.MaxValue : nums2[partitionY];

            if(maxLeftX<=minRightY&&maxLeftY<=minRightX)
            {
                    if((nums1.Length+nums2.Length)%2==0)
                    {
                        return (Math.Max(maxLeftX,maxLeftY)+Math.Min(minRightX,minRightY))/2.0;
                    }
                    else
                    {
                        return Math.Max(maxLeftX,maxLeftY);
                    }
            }
            else if(maxLeftX>minRightY)
            {
                high=partitionX-1;
            }
            else
                low=partitionX+1;
        }
        throw new ArgumentException("");
    }
}
