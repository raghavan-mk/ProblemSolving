using System;
using System.Collections.Generic;

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

namespace problemsolving {
    public class Staircase {
        public int Solution (int numSteps) {
            if(numSteps == 0)
                return 1;
            if (numSteps == 1)
                return 1;
            if (numSteps == 2)
                return 2;
            else
                return Solution(numSteps - 2) + Solution(numSteps - 1);
        }
    }
}