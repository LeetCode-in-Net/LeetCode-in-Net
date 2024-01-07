namespace LeetCodeNet.G0201_0300.S0295_find_median_from_data_stream {

using Xunit;

public class MedianFinderTest {
    [Fact]
    public void MedianFinder() {
        MedianFinder medianFinder = new MedianFinder();
        // arr = [1]
        medianFinder.AddNum(1);
        // arr = [1, 2]
        medianFinder.AddNum(2);
        // return 1.5 (i.e., (1 + 2) / 2)
        Assert.Equal(1.5, medianFinder.FindMedian());
        // arr[1, 2, 3]
        medianFinder.AddNum(3);
        // return 2.0
        Assert.Equal(2.0, medianFinder.FindMedian());
    }

    [Fact]
    public void MedianFinder2() {
        MedianFinder medianFinder = new MedianFinder();
        medianFinder.AddNum(1);
        medianFinder.AddNum(3);
        medianFinder.AddNum(-1);
        Assert.Equal(1.0, medianFinder.FindMedian());
    }
}
}
