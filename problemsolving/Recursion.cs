using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving {
    public class Recursion {
        //fancy way to multiply two integers !
        public int Calculate (int a, int b) {
            if (a == 0) return 1;
            return Calculate (a - 1, b) + b;
        }

        public double Calculate2 (int a, int b) {
            if (b == 0) return 1;
            return Math.Pow (a, b) + Calculate2 (a, b - 1);
        }
        public List<int> coins = new List<int> { 3, 1, 5, 6 };

        // Dictionary<int, int> coins1 =
        //     new Dictionary<int, int> {
        //         [1] = 1,
        //         [3] = 1,
        //         [5] = 1
        //     };

        public Dictionary<int, int> coins1 =
            new Dictionary<int, int> {
                [3] = 1,
                [5] = 1,
                [1] = 1,
                [6] = 1
            };
        public int max;
        public int MinCoins (int n, int minChange) {

            if (n <= 0)
                return ++minChange;
            else if (coins1.GetValueOrDefault (n) == 1)
                return ++minChange;
            else
                return MinCoins (n - max, ++minChange);
        }

        public int MinCoinsI (int n) {

            var maxValue = coins.Max ();
            int minchange = 0;

            if (n < maxValue) {
                for(int i=0;i<n;i++){
                    
                }
            } else {
                for (int i = 0; i < n; i += maxValue) {
                    ++minchange;
                }
            }

            return minchange;
        }
    }
}