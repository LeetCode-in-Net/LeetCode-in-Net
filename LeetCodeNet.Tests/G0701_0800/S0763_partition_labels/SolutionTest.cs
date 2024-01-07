namespace LeetCodeNet.G0701_0800.S0763_partition_labels {

using Xunit;
using System.Collections.Generic;

public class SolutionTest {
    [Fact]
    public void PartitionLabels() {
        Assert.Equal(new List<int> {9, 7, 8}, new Solution().PartitionLabels("ababcbacadefegdehijhklij"));
    }

    [Fact]
    public void PartitionLabels2() {
        Assert.Equal(new List<int> {10}, new Solution().PartitionLabels("eccbbbbdec"));
    }
}
}
