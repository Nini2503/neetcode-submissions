public class TimeMap {
    public class Node{
        public string value;
        public int timestamp;
        public Node(string value,int timestamp)
        {
            this.value=value;
            this.timestamp=timestamp;
        }
    }
    Dictionary<string,List<Node>> map;
    public TimeMap() {
        map=new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key))
            map[key]=new List<Node>();
        map[key].Add(new Node(value,timestamp));
    }
    
    public string Get(string key, int timestamp) {
        string res="";
        if(map.ContainsKey(key))
        {
            List<Node> list=map[key];
            int low=0;
            int high=list.Count-1;
            while(low<=high)
            {
                int mid=(low+high)/2;
                if(list[mid].timestamp==timestamp)
                    return list[mid].value;
                if(list[mid].timestamp>timestamp)
                    high=mid-1;
                else
                {
                    low=mid+1;
                    res=list[mid].value;
                }
            }
        }
        return res;
    }
}
