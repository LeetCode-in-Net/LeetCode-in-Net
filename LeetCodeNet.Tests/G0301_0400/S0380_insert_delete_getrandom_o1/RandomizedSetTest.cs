namespace LeetCodeNet.G0301_0400.S0380_insert_delete_getrandom_o1 {

using System;
using System.Collections.Generic;
using Xunit;

public class RandomizedSetTest {
    [Fact]
    public void RandomizedSetBasic() {
        var result = new List<string>();
        RandomizedSet randomizedSet = null;
        result.Add("null");
        randomizedSet = new RandomizedSet();
        result.Add(randomizedSet.Insert(1).ToString().ToLower());
        result.Add(randomizedSet.Remove(2).ToString().ToLower());
        result.Add(randomizedSet.Insert(2).ToString().ToLower());
        int random = randomizedSet.GetRandom();
        result.Add(random.ToString());
        result.Add(randomizedSet.Remove(1).ToString().ToLower());
        result.Add(randomizedSet.Insert(2).ToString().ToLower());
        result.Add(randomizedSet.GetRandom().ToString());
        var expected1 = new List<string> {"null", "true", "false", "true", "1", "true", "false", "2"};
        var expected2 = new List<string> {"null", "true", "false", "true", "2", "true", "false", "2"};
        if (random == 1) {
            Assert.Equal(expected1, result);
        } else {
            Assert.Equal(expected2, result);
        }
    }
}
}
