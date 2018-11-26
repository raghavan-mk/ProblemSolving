using System;
using System.Collections.Generic;

namespace problemsolving {

    //problem definiton

    // Let’s work through the following problem.

    // There exists a staircase with N steps, and you can climb up either 1 or 2 steps at a time.

    // Given N, write a function that returns the number of unique ways you can climb the staircase.
    // The order of the steps matters.

    // For example, if N is 4, then there are 5 unique ways:

    // 1, 1, 1, 1
    // 2, 1, 1
    // 1, 2, 1
    // 1, 1, 2
    // 2, 2
    public class Staircase {

        public int Solution (int numSteps) {
            if (numSteps < 0)
                return 0;
            if (numSteps <= 1)
                return 1;
            else
                return Solution (numSteps - 2) + Solution (numSteps - 1);
        }
        //take either one or three steps at a time
        public int StairCase2 (int numSteps) {
            if (numSteps < 0)
                return 0;
            if (numSteps <= 1)
                return 1;
            else return StairCase2 (numSteps - 1) + StairCase2 (numSteps - 3);
        }
        //take either 1,2 or 3 steps at a time
        public int StairCase3 (int numSteps) {
            if (numSteps < 0)
                return 0;
            if (numSteps <= 1)
                return 1;
            else return StairCase3 (numSteps - 1) + StairCase3 (numSteps - 2) + StairCase3 (numSteps - 3);
        }

        public int StairCase3Memo (int steps, int[] paths) {
            if (steps < 0)
                return 0;
            if (steps <= 1)
                return 1;
            else {
                if (paths[steps] == 0) {
                    paths[steps] = StairCase3Memo (steps - 1, paths) +
                        StairCase3Memo (steps - 2, paths) +
                        StairCase3Memo (steps - 3, paths);
                }
            }
            return paths[steps];
        }

        public int StairCase3I (int steps) {
            if (steps < 0)
                return 0;
            if (steps <= 1)
                return 1;
            int[] paths = new int[3];
            paths[0] = 1;
            paths[1] = 1;
            paths[2] = 2;
            for (int i = 3; i <= steps; i++) {
                var count = paths[0] + paths[1] + paths[2];
                Console.WriteLine (paths[0] + " " + paths[1] + " " + paths[2]);
                paths[0] = paths[1];
                paths[1] = paths[2];
                paths[2] = count;
            }
            return paths[2];
        }

        public int StairCase3I_MinPath (int steps) {

            int min = Int32.MaxValue;

            int[] paths = new int[steps + 1];

            Array.ForEach (paths, s => s = Int32.MaxValue);

            paths[0] = 0;
            paths[1] = 1;

            return min;
        }
    }
}