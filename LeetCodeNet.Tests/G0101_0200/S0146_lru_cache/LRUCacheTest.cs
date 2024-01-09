namespace LeetCodeNet.G0101_0200.S0146_lru_cache {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void LruCache() {
        LRUCache lruCache = new LRUCache(2);
        // cache is {1=1}
        lruCache.Put(1, 1);
        // cache is {1=1, 2=2}
        lruCache.Put(2, 2);
        // return 1
        Assert.Equal(1, lruCache.Get(1));
        // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
        lruCache.Put(3, 3);
        // returns -1 (not found)
        Assert.Equal(-1, lruCache.Get(2));
        // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
        lruCache.Put(4, 4);
        // return -1 (not found)
        Assert.Equal(-1, lruCache.Get(1));
        // return 3
        Assert.Equal(3, lruCache.Get(3));
        // return 4
        Assert.Equal(4, lruCache.Get(4));
    }
}
}
