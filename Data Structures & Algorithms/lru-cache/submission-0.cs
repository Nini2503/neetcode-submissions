public class LRUCache {

    int capacity;
    Dictionary<int,LinkedListNode<(int key,int value)>> cache;
    LinkedList<(int key,int value)> order;
    public LRUCache(int capacity) {
        this.cache=new Dictionary<int,LinkedListNode<(int key,int value)>>();
        this.capacity=capacity;
        this.order=new LinkedList<(int key,int value)>();
    }
    
    public int Get(int key) {
        if(cache.ContainsKey(key))
        {
            var node=cache[key];
            order.Remove(node);
            order.AddLast(node);
            return node.Value.value;
        }
        else
            return -1;
    }
    
    public void Put(int key, int value) {
        int val=Get(key);
        if(val==-1)
        {
            var node=new LinkedListNode<(int key,int value)>((key,value));
            if(order.Count==capacity)
            {
                var leastused=order.First.Value;
                order.RemoveFirst();
                cache.Remove(leastused.key);
            }
            order.AddLast(node);
            cache[key]=node;
        }
        else
        {
            var node=cache[key];
            node.Value=(key,value);
        }
        
    }
}
