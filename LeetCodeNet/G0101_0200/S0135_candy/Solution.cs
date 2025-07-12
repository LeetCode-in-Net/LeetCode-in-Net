namespace LeetCodeNet.G0101_0200.S0135_candy {

// #Hard #Array #Greedy #Top_Interview_150_Array/String
// #2025_07_12_Time_1_ms_(99.02%)_Space_47.02_MB_(99.09%)

using System;

public class Solution {
    private bool isFirstIteration;

    public enum RatingState {
        increase,
        decrease,
        stable,
        none
    }

    private RatingState GetNewState(int prevRating, int currentRating) {
        if (currentRating > prevRating) {
            return RatingState.increase;
        }
        if (currentRating < prevRating) {
            return RatingState.decrease;
        }
        return RatingState.stable;
    }

    private void CountSum(RatingState currentState, ref int n, ref int totalCandies, ref int startNum) {
        int res = 0;
        switch (currentState) {
            case (RatingState.increase):
                if (!isFirstIteration) {
                    startNum++;
                }
                res = (2 * startNum + n - 1) * (n) / 2;
                totalCandies += res;
                startNum = startNum + n - 1;
                break;
            case (RatingState.decrease):
                if (!isFirstIteration){
                    startNum--;
                }
                var start = startNum - n + 1;
                var end = startNum;
                res = (end + start) * n / 2;
                totalCandies += res;
                if (start <= 0) {
                    start--;
                    int toRemove = 0;
                    if (isFirstIteration)
                        toRemove = -1;
                    totalCandies += (n + 1 + toRemove) * (-start);
                }
                else if (start > 1) {
                    totalCandies -= (start - 1) * (n);
                }
                startNum = 1;
                break;
            case (RatingState.stable):
                totalCandies += n;
                startNum = 1;
                break;
            case (RatingState.none):
                return;
        }
        isFirstIteration = false;
        n = 1;
    }

    public int Candy(int[] ratings) {
        if (ratings.Length == 1) {
            return 1;
        }
        RatingState currentState = RatingState.none;
        int prevRating = ratings[0];
        int totalCandies = 0;
        int n = 2;
        int startNum = 1;
        isFirstIteration = true;
        for (int i = 1; i < ratings.Length; i++) {
            var newState = GetNewState(prevRating, ratings[i]);
            prevRating = ratings[i];
            if (newState != currentState) {
                CountSum(currentState, ref n, ref totalCandies, ref startNum);
                currentState = newState;
            } else {
                n++;
            }
        }
        CountSum(currentState, ref n, ref totalCandies, ref startNum);
        return totalCandies;
    }
}
}
