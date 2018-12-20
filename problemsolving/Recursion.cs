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

<<<<<<< HEAD
        public void RecurseNumbers(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i}" + " ");
                RecurseNumbers(i + 1);
            }
            Console.WriteLine();
        }

        public int[] BinarySort_Recurse(int[] input, int index)
        {
            for (int i = 0; i < input.Length; i++)
            {
                BinarySort_Recurse(input, i + 1);
                //for (int j = i + 1; j < input.Length; j++)
                {
                    var j = input[i];
                    var k = input[i + 1];
                    if (k < j)
                    {
                        var t = k;
                        j = k;
                        k = t;
                    }
                }
            }
            return input;
        }

        public int[] BinarySort_I(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if(input[i] > input[j])
                    {
                        var t = input[i];
                        input[i] = input[j];
                        input[j] = t;
                    }

                }
            }
            return input;
=======
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

            for (int i = index; i < inputs.Length-1; i++) {

                if (inputs[index] > inputs[index + 1]) {
                    var t = inputs[index];
                    inputs[index] = inputs[index + 1];
                    inputs[index + 1] = t;
                }

                BubbleSort_R (inputs, index + 1);

            }
            return inputs;
>>>>>>> 5d63a864bee419dcaa0b02bf8fe80c7106023fd2
        }
    }
}