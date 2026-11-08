public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> s=new Stack<int>();
        int[] res=new int[temperatures.Length];
        for(int i=0;i<temperatures.Length;i++)
        {
            while(s.Count>0 && temperatures[s.Peek()]<temperatures[i])
            {
                int j=s.Pop();
                res[j]=i-j;
            }
            s.Push(i);
        }
        return res;
    }
}
