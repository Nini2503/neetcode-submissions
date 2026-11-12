class Solution {//REVISION-need to do
    public int carFleet(int target, int[] position, int[] speed) {
        int[][] pairs=new int[position.length][2];
        for(int i=0;i<position.length;i++)
        {
            pairs[i][0]=position[i];
            pairs[i][1]=speed[i];
        }
        //sort in descending position
        Arrays.sort(pairs,(a,b)->b[0]-a[0]);
        int res=1;
        double prevTime=(double)(target-pairs[0][0])/pairs[0][1];
        for(int i=1;i<position.length;i++)
        {
            double currTime=(double)(target-pairs[i][0])/pairs[i][1];
            if(currTime>prevTime)
            {
                res++;
                prevTime=currTime;
            }
        }
        return res;
    }
}
