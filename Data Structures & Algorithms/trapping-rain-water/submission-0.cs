public class Solution {
    public int Trap(int[] height) {
        int m=height.Length;
        int[] left=new int[m];
        int[] right=new int[m];
        left[0]=height[0];
        right[m-1]=height[m-1];

        for(int i=1;i<m;i++)
            left[i]=Math.Max(left[i-1],height[i]);

        for(int i=m-2;i>=0;i--)
            right[i]=Math.Max(right[i+1],height[i]);

        int vol=0;
        for(int i=0;i<m;i++)
        {
            vol+=Math.Min(left[i],right[i])-height[i];
        }
        return vol;
    }
}
