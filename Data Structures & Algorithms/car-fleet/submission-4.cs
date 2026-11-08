public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pair=new int[position.Length][];
        for(int i=0;i<position.Length;i++)
        {
            pair[i]=new int[2];
            pair[i][0]=position[i];
            pair[i][1]=speed[i];
        }
        Array.Sort(pair,(a,b)=>b[0].CompareTo(a[0]));
        double currTime=(target-pair[0][0])/pair[0][1];

        int fleet=1;
        for(int i=1;i<position.Length;i++)
        {
            double nextTime=(double)(target-pair[i][0])/pair[i][1];
            if(nextTime>currTime)
            {
                currTime=nextTime;
                fleet++;
            }
        }
        return fleet;
    }
   
}
