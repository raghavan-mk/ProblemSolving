using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving
{
    public class Recursion
    {
        //fancy way to multiply two integers !
        public int Calculate(int a, int b)
        {
            if (a == 0) return 1;
            return Calculate(a - 1, b) + b;
        }

        public double Calculate2(int a, int b)
        {
            if (b == 0) return 1;
            return Math.Pow(a, b) + Calculate2(a, b - 1);
        }
        public List<int> coins = new List<int> { 3, 1, 5, 6 };

        // Dictionary<int, int> coins1 =
        //     new Dictionary<int, int> {
        //         [1] = 1,
        //         [3] = 1,
        //         [5] = 1
        //     };

        public Dictionary<int, int> coins1 =
            new Dictionary<int, int>
            {
                [3] = 1,
                [5] = 1,
                [1] = 1,
                [6] = 1
            };
        public int max;
        public int MinCoins(int n, int minChange)
        {

            if (n <= 0)
                return ++minChange;
            else if (coins1.GetValueOrDefault(n) == 1)
                return ++minChange;
            else
                return MinCoins(n - max, ++minChange);
        }

        public int MinCoinsI(int n)
        {

            var maxValue = coins.Max();
            int minchange = 0;

            if (n < maxValue)
            {
                for (int i = 0; i < n; i++)
                {

                }
            }
            else
            {
                for (int i = 0; i < n; i += maxValue)
                {
                    ++minchange;
                }
            }

            return minchange;
        }

        public int[] BubbleSort_I (int[] inputs) {
            for (int i = 0; i < inputs.Length; i++) {
                for (int j = i + 1; j < inputs.Length; j++) {
                    if (inputs[i] > inputs[j]) {
                        var t = inputs[i];
                        inputs[i] = inputs[j];
                        inputs[j] = t;
                    }
                }
            }
            return inputs;
        }

        public int[] BubbleSort_R (int[] inputs, int index) {

            for (int i = index; i < inputs.Length - 1; i++) {

                if (inputs[index] > inputs[index + 1]) {
                    var t = inputs[index];
                    inputs[index] = inputs[index + 1];
                    inputs[index + 1] = t;
                }

                BubbleSort_R (inputs, index + 1);

            }
            return inputs;
        }

        public void QuickSort (int[] nos, int l, int r) {

            if (l <= r) {
                var par = Partition (nos, l, r);
                QuickSort (nos, l, par - 1);
                QuickSort (nos, par + 1, r);
            }
        }
        public int Partition (int[] nos, int l, int r) {

            // var l = 0;
            // var r = nos.Length - 2;
            var max = r;
            var p = nos[r];

            while (l <= r) {

                if (nos[l] > p && nos[r] < p) {
                    Swap (ref nos[l], ref nos[r]);
                }

                if (nos[l] < p)
                    ++l;
                if (nos[r] >= p)
                    --r;
            }
            if (nos[l] > p)
                Swap (ref nos[l], ref nos[max]);
            return l;
        }

        public void Swap (ref int i, ref int j) {
            var t = i;
            i = j;
            j = t;
        }

        // public sorted MergeSort(int[] nos){
        //     var mid = nos.Length/2;
        //     var merged1 = MergeSort(nos);
        //     var merged2 = MergeSort(nos);

        // }

        public void MergeSort (int[] nos, int l, int r) {
            if (l < r) {
                var m = (l + r) / 2;
                MergeSort (nos, l, m);
                MergeSort (nos, m + 1, r);
                for (int i = l; i < r; i++) {
                    Console.Write (nos[i] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}