using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using problemsolving;
using ProblemSolving;

namespace tests {
    [TestClass]
    public class TestCases {
        [TestMethod]
        public void CoinChange_Test () {
            int[] coins = new int[] { 1, 3, 5 };
            // int[] coins = new int[] { 1, 3, 5, 6 };
            var result = CoinChange.CoinChangeR (4, coins);
            Console.WriteLine (result);
        }

        [TestMethod]
        public void StairCaseProblem () {
            var result = new Staircase ().Solution (4);
            Assert.AreEqual (result, 5);

        }

        [TestMethod]
        public void StairCaseProblem2 () {
            var result = new Staircase ().StairCase2 (6);
            Assert.AreEqual (6, result);

        }

        [TestMethod]
        public void StairCaseProblem3Memo () {
            int[] paths = new int[6];
            Array.Clear (paths, 0, paths.Length);
            var result = new Staircase ().StairCase3Memo (5, paths);
            Assert.AreEqual (13, result);
        }

        [TestMethod]
        public void StairCaseProblem3I () {

            var result = new Staircase ().StairCase3I (5);
            Assert.AreEqual (13, result);
        }

        [TestMethod]
        public void StairCaseProblem3I_MinPath () {

            var result = new Staircase ().StairCase3I_MinPath (5);
            Assert.AreEqual (2, result);
        }

        [TestMethod]
        public void DistinctElements () {
            var result = new RandomProblems ()
                .DistinctElements (3, 10, new int[] { 1, 2, 3, 3, 4, 4, 5, 5, 6, 6 }.ToList ());
            Assert.AreEqual (result, 4);

        }

        [TestMethod]
        public void FibI_Test () {
            var r = new RandomProblems ().FibI (6);
            Assert.AreEqual (r, 5);
        }

        [TestMethod]
        public void PrimFibI_Test () {
            var r = new RandomProblems ().PrimFibISum (100, 90, 100);
            Assert.AreEqual (r, 0);
        }

        [TestMethod]
        public void IfPrime_Test () {
            var r = new RandomProblems ().IfPrime (89);
            Assert.IsTrue (r);
        }

        [TestMethod]
        public void TicketBuyers_Test () {
            var turns = new RandomProblems ().TicketBuyersQueue (new int[] { 5, 5, 2, 3 }, 3);
            Assert.AreEqual (11, turns);

            turns = new RandomProblems ().TicketBuyersQueue (new int[] { 2, 6, 3, 4, 5 }, 2);
            Assert.AreEqual (12, turns);

        }

        [TestMethod]
        public void Calculate_Test () {
            var result = new Recursion ().Calculate (12, 3);
            Assert.AreEqual (37, result);
        }

        [TestMethod]
        public void Calculate2_Test () {
            var result = new Recursion ().Calculate2 (3, 3);
            Assert.AreEqual (40, result);
        }

        [TestMethod]
        public void MinCoins_Test () {
            Recursion r = new Recursion ();
            r.max = r.coins1.Keys.Max ();
            var result = r.MinCoins (8, 0);
            Assert.AreEqual (2, result);
        }

        [TestMethod]
        public void MinCoinsI_Test () {
            Recursion r = new Recursion ();
            r.max = r.coins1.Keys.Max ();
            var result = r.MinCoinsI (6);
            Assert.AreEqual (1, result);
        }

        [TestMethod]
        public void ReverseString () {
            var result = new Functional ().ReverseOddIndexedChar_I ("Python");
            Assert.AreEqual ("yhnotP", result);
        }

        [TestMethod]
        public void ReverseString_Functional () {
            var result = new Functional ().ReverseOddIndexedChar ("ISI");
            Assert.AreEqual ("SII", result);
        }

        [TestMethod]
        public void ReverseOddIndexedString () {
            var result = new Functional ().ReverseOddIndexedString ("Python Is Truly Interesting Programming Language");
            Assert.AreEqual ("yhnotP Xs rlyuT Xntxrxstxng rgamngimroP Lxngxxgx", result);
        }

        [TestMethod]
        public void ReverseOddIndexedString2 () {
            var result = new Functional ().ReverseOddIndexedString ("God Is Good And Bad");
            Assert.AreEqual ("odG Xs odoG Xnd adB", result);
        }

        [TestMethod]
        public void ReverseOddIndexedString3 () {

            var s = "God Is Good And Bad";
            var odds = s.ReverseOddIndexedString ();
            var evens = s.ReplaceVowelsInEvenIndexedString ();
            var join = odds.Zip (evens, (o, e) => o + " " + e);

            //zip only matches equal number of values in both collections            
            var result = s.Length % 2 == 1 ? (String.Join (" ", join) + " " + odds.Last ().Trim ()) :
                String.Join (" ", join).Trim ();

            Assert.AreEqual ("odG Xs odoG Xnd adB", result);
        }

        [TestMethod]
        public void BuyChocolates_Test () {

            // var n = Convert.ToInt64 (Console.ReadLine ());
            // var c = Console.ReadLine ().Split (',');

            // Dictionary<long, long> chocolates = new Dictionary<long, long> ();
            // for (long i = 0; i < c.Length; i++) {
            //     var s = c[i].Split (':');
            //     chocolates.Add (Convert.ToInt64 (s[2]), Convert.ToInt64 (s[1]));
            // }
            // var price = BuyChocolates (chocolates, n);
            // Console.WriteLine (price);

            SortedDictionary<int, int> chocolates = new SortedDictionary<int, int> {
                [30] = 2,
                [15] = 8
            };

            var price = new RandomProblems ().BuyChocolates (chocolates, 5);
            Assert.AreEqual (75, price);

        }

        [TestMethod]
        public void XSeries_Test () {
            var str = "11, 5, 19, 2, 8, 3, 4";
            var input = str.Split (',').Select (Int32.Parse).ToList ();
            var result = new RandomProblems ().XSeries (input);
            var r = String.Join (',', result);
            var result1 = new RandomProblems ().XSeries (new List<int> { 67, 32, 1 });

            //new RandomProblems ().XSeries (new List<int> { 1, 2, 3, 3, 2 ,4});
            //var result = new RandomProblems ().XSeries (new List<int> { 1,2,3 });
            //Assert.IsTrue (true);
        }

        [TestMethod]
        public void DecodeMessage_Test () {
            var decode = new RandomProblems ().DecodeMessage_R ("123", 3);
            Assert.AreEqual (3, decode);
        }

        [TestMethod]
        public void Fib_Memo_Test () {
            long n = 8;
            long?[] memo = new long?[n + 1];
            memo[0] = 1;
            memo[1] = 1;
            for (int i = 1; i < memo.Length; i++) {
                memo[i] = null;
            }
            var result = new RandomProblems ().Fib_Memo (8, memo);
            Assert.AreEqual (21, result);
        }

        [TestMethod]
        public void BalanceAmount () {
            // var result = new RandomProblems().BalanceAmount(new int[]{2,3,5,10},10,0, new Dictionary<string, long>());
            var result = new RandomProblems ().BalanceAmount (new int[] { 1, 2 }, 3, 0, new Dictionary<string, long> ());
            Assert.AreEqual (result, 2);
        }

        [TestMethod]
        public void MaximizeProfit_Test () {
            RandomProblems r = new RandomProblems ();
            var result = r.MaximizeProfit (new int[] { 10, 100, 20, 30, 40, 50 });
            Console.WriteLine (result);
            Assert.AreEqual (result, 120);
            result = r.MaximizeProfit (new int[] { 30, 42, 25, 85, 100, 70, 110 });
            Console.WriteLine (result);
            Assert.AreEqual (result, 127);
        }

        [TestMethod]
        public void Bubblesort_I_Test () {
            var r = new Recursion ().BubbleSort_I (new int[] { 3, 2, 1 });
            Assert.AreEqual (3, r[2]);
        }

        [TestMethod]
        public void Bubblesort_R_Test () {
            var r = new Recursion ().BubbleSort_R (new int[] { 3, 2, 1, 8, 9, 0, 100, 1001 }, 0);
            Assert.AreEqual (1001, r[7]);
        }
    }
}