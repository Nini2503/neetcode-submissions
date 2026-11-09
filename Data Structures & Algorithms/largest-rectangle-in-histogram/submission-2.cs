public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> s=new Stack<int>();
        int maxArea=0;
        s.Push(-1);
        for(int i=0;i<heights.Length;i++)
        {
            while(s.Peek()!=-1 && heights[s.Peek()]>heights[i])
            {
                int area=heights[s.Pop()]*(i-s.Peek()-1);
                maxArea=Math.Max(maxArea,area);
                
            }
            s.Push(i);
        }
        while(s.Peek()!=-1 )
        {
            int area=heights[s.Pop()]*(heights.Length-s.Peek()-1);
            maxArea=Math.Max(maxArea,area);
        }
        return maxArea;
    }
}
