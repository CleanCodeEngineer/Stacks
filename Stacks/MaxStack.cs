namespace Stacks
{
    // O(1) time for Push(), Pop(), and GetMax().
    // O(m) additional space, where m is the number of operations performed on the stack.
    public class MaxStack
    {
        Stack<int> _stack = new Stack<int>();
        Stack<int> _maxesStack = new Stack<int>();

        // Add a new item to the top of our stack, If the item is greater
        // than or equal to the last item in _maxesStack, it's
        // the new max! So we'll add it to _maxesStack.
        public void Push(int item)
        {
            _stack.push(item);

            if (_maxesStack.Count == 0 || item >= _maxesStack.peek())
            {
                _maxesStack.push(item);
            }
        }

        // Remove and return the top item from our stack. If it equals
        // the top item in _maxesStack, they must have been pushed in together.
        // So we'll pop it out of _maxesStack too.
        public int Pop()
        {
            int item = _stack.pop();

            if (item == _maxesStack.peek())
            {
                _maxesStack.pop();
            }

            return item;
        }


        // The last item in _maxesStack is the max item in our stack.
        public int GetMax()
        {
            return _maxesStack.peek();
        }
    }
}
