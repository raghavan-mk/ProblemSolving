using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using problemsolving;

namespace tests {
    [TestClass]
    public class TestCases {
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
            var result = new Recursion ().MinCoins (11, 0);
            Assert.AreEqual (3, result);
        }

        [TestMethod]
        public void MinCoinsI_Test () {
            var result = new Recursion ().MinCoinsI (6);
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

            Dictionary<int, int> chocolates = new Dictionary<int, int> {
                [2] = 30,
                [8] = 15
            };

            var price = new RandomProblems ().BuyChocolates (chocolates, 5);
            Assert.AreEqual (75, price);

        }
    }
}