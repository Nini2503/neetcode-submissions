public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var q=new LinkedList<int>();
        int front=0;
        int[] output=new int[nums.Length-k+1];
        for(int rear=0;rear<nums.Length;rear++)
        {
            while(q.Count>0 && nums[q.Last.Value]<nums[rear])
                q.RemoveLast();

            q.AddLast(rear);

            if(front>q.First.Value)
                q.RemoveFirst();

            if(rear+1>=k)
            {
                output[front]=nums[q.First.Value];
                front++;
            }
            
            
        }
        return output;
    }
}
