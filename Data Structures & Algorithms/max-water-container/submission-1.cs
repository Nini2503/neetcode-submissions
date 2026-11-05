public class Solution {
    public int MaxArea(int[] heights) {
        int left=0;
        int right=heights.Length-1;
        int maxArea=0;
        while(left<right)
        {
            int area=(Math.Min(heights[left],heights[right]))*(right-left);
            maxArea=Math.Max(area,maxArea);
            if(heights[left]<heights[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}
