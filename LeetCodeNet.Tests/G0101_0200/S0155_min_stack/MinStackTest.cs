namespace LeetCodeNet.G0101_0200.S0155_min_stack {

using Xunit;

public class MinStackTest {
    [Fact]
    public void MinStack() {
        MinStack minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        // return -3
        Assert.Equal(-3, minStack.GetMin());
        minStack.Pop();
        // return 0
        Assert.Equal(0, minStack.Top());
        // return -2
        Assert.Equal(-2, minStack.GetMin());
    }
}
}
