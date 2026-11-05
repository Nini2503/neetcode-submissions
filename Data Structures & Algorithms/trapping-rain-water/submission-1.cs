public class Solution {
    public int Trap(int[] height) {
        int m=height.Length;
        
        int leftMax=height[0];
        int rightMax=height[m-1];

        int l=0,r=m-1;
        int vol=0;
        while(l<r)
        {
            if(leftMax<rightMax)
            {
                l++;
                leftMax=Math.Max(leftMax,height[l]);
                vol+=leftMax-height[l];
            }
            else
            {
                r--;
                rightMax=Math.Max(rightMax,height[r]);
                vol+=rightMax-height[r];
            }
        }
        return vol;
    }
}
