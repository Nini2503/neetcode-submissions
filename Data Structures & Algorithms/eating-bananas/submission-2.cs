public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low=1;
        Array.Sort(piles);
        int high=piles[piles.Length-1];
        int res=high;
        while(low<=high)
        {
            int mid=(low+high)/2;
            long time=0;
            foreach(int pile in piles)
                time+=(int)Math.Ceiling((double)pile/mid);
            Console.WriteLine(mid+" "+time);
            if(time<=h)
            {
                res=mid;
                high=mid-1;
            }
            else
                low=mid+1;
        }
        return res;
    }
}
