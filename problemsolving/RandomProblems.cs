using System;
using System.Linq;

namespace problemsolving {
    //Given an array of N integers, write a program to remove K elements from it such that there are minimum number of unique integers left in the array and print the number of unique integers.
    // Sample Input	Sample Output	Explanation
    // 3,10
    // 1,2,3,3,4,4,5,5,6,6	4	After removing 1, 2, 3 from the input, 3,4,4,5,5,6,6 will be left in the array. Hence the unique elements left in the array are 3,4,5,6. Hence the count is 4.

    public class RandomProblems {
        public int DistinctElements(int skip, string numbers) =>
             numbers.Split(',').Select(int.Parse).ToList().Skip(skip).Distinct().Count();
    }
}