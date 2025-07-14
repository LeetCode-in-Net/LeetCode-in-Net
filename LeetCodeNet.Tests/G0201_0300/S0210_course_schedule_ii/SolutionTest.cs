namespace LeetCodeNet.G0201_0300.S0210_course_schedule_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void CourseScheduleII() {
        int[][] prerequisites = new int[][] { new int[] {1, 0} };
        int numCourses = 2;
        Assert.Equal(new int[] {0, 1}, new Solution().FindOrder(numCourses, prerequisites));
    }

    [Fact]
    public void CourseScheduleII2() {
        int[][] prerequisites = new int[][] { new int[] {1, 0}, new int[] {2, 0}, new int[] {3, 1}, new int[] {3, 2} };
        int numCourses = 4;
        Assert.Equal(new int[] {0, 1, 2, 3}, new Solution().FindOrder(numCourses, prerequisites));
    }

    [Fact]
    public void CourseScheduleII3() {
        int[][] prerequisites = new int[][] { };
        int numCourses = 1;
        Assert.Equal(new int[] {0}, new Solution().FindOrder(numCourses, prerequisites));
    }
}
}
