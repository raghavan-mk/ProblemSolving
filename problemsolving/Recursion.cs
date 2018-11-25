using System;

namespace problemsolving {
    public class Recursion {
        //fancy way to multiply two integers !
        public int Calculate (int a, int b) {
            if (a == 0) return 1;
            return Calculate (a - 1, b) + b;
        }

         public double Calculate2 (int a, int b) {
            if (b == 0) return 1;
            return Math.Pow(a,b) + Calculate2(a, b-1);
        }

    }
}