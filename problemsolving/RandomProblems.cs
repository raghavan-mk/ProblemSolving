using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving {
    //Given an array of N integers, write a program to remove K elements from it such that there are minimum number of unique integers left in the array and print the number of unique integers.
    // Sample Input	Sample Output	Explanation
    // 3,10
    // 1,2,3,3,4,4,5,5,6,6	4	After removing 1, 2, 3 from the input, 3,4,4,5,5,6,6 will be left in the array. Hence the unique elements left in the array are 3,4,5,6. Hence the count is 4.

    public class RandomProblems {
        public int DistinctElements (int skip, string numbers) =>
            numbers.Split (',').Select (int.Parse).ToList ().Skip (skip).Distinct ().Count ();

        public long FibI (long n) {

            long n1 = 1;
            long n2 = 1;

            for (long i = 3; i < n; i++) {
                var nxt = n2 + n1;
                n1 = n2;
                n2 = nxt;
            }
            return n2;
        }

        public long PrimFibISum (long n, long min, long max) {

            if (n == 0 || n == 1) return 0;
            if (n == 2) return 1;
            if (n == 3) return 2;

            long primesSum = 0;
            long n1 = 0;
            long n2 = 1;

            for (long i = 2; i < n; i++) {
                var nxt = n2 + n1;
                n1 = n2;
                n2 = nxt;

                if (n2 >= min && n2 <= max) {
                    if (IfPrime (n2)) {
                        Console.WriteLine(n2);
                        primesSum += n2;
                    }
                }
            }
            return primesSum;
        }

        public bool IfPrime (long n) {
            long i = 2;

            if (n == 1) return true;
            if (n == 2) return true;

            while (i <= Math.Sqrt (n)) {
                if (n % i == 0)
                    return false;
                else
                    i++;
            }
            return true;

        }
    }
}