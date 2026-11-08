public class MinStack {
    Stack<int> s;
    Stack<int> minStack;
    public MinStack() {
        s=new Stack<int>();
        minStack=new Stack<int>();
    }
    
    public void Push(int val) {
        s.Push(val);
        if(minStack.Count==0||minStack.Peek()>=val)
            minStack.Push(val);
    }
    
    public void Pop() {
        if(s.Peek()==minStack.Peek())
            minStack.Pop();
        s.Pop();

    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
