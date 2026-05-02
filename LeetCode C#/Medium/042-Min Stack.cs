Link: https://leetcode.com/problems/min-stack/
Language: C#







    public class MinStack
    {
        Stack<int> stack;
        Stack<int> minstack;

        public MinStack()
        {
            stack = [];
            minstack = [];
        }

        public void Push(int val)
        {
            stack.Push(val);

            if (minstack.Count == 0 || minstack.Peek() >= val)
                minstack.Push(val);
        }

        public void Pop()
        {
            int val = stack.Pop();
            if (minstack.Peek() == val)
                minstack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minstack.Peek();
        }
    }
/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */