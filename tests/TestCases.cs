using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using problemsolving;
using ProblemSolving;

namespace tests
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void CoinChange_Test()
        {
            int[] coins = new int[] { 4, 5, 9 };
            // int[] coins = new int[] { 1, 3, 5, 6 };
            var result = CoinChange.CoinChangeR(29, coins);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void StairCaseProblem()
        {
            var result = new Staircase().Solution(4);
            Assert.AreEqual(result, 5);

        }

        [TestMethod]
        public void StairCaseProblem2()
        {
            var result = new Staircase().StairCase2(6);
            Assert.AreEqual(6, result);

        }

        [TestMethod]
        public void StairCaseProblem3Memo()
        {
            int[] paths = new int[6];
            Array.Clear(paths, 0, paths.Length);
            var result = new Staircase().StairCase3Memo(5, paths);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void StairCaseProblem3I()
        {

            var result = new Staircase().StairCase3I(5);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void StairCaseProblem3I_MinPath()
        {

            var result = new Staircase().StairCase3I_MinPath(5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DistinctElements()
        {
            var result = new RandomProblems()
                .DistinctElements(3, 10, new int[] { 1, 2, 3, 3, 4, 4, 5, 5, 6, 6 }.ToList());
            Assert.AreEqual(result, 4);

        }

        [TestMethod]
        public void FibI_Test()
        {
            var r = new RandomProblems().FibI(6);
            Assert.AreEqual(r, 5);
        }

        [TestMethod]
        public void PrimFibI_Test()
        {
            var r = new RandomProblems().PrimFibISum(100, 90, 100);
            Assert.AreEqual(r, 0);
        }

        [TestMethod]
        public void IfPrime_Test()
        {
            var r = new RandomProblems().IfPrime(89);
            Assert.IsTrue(r);
        }

        [TestMethod]
        public void TicketBuyers_Test()
        {
            var turns = new RandomProblems().TicketBuyersQueue(new int[] { 5, 5, 2, 3 }, 3);
            Assert.AreEqual(11, turns);

            turns = new RandomProblems().TicketBuyersQueue(new int[] { 2, 6, 3, 4, 5 }, 2);
            Assert.AreEqual(12, turns);

        }

        [TestMethod]
        public void Calculate_Test()
        {
            var result = new Recursion().Calculate(12, 3);
            Assert.AreEqual(37, result);
        }

        [TestMethod]
        public void Calculate2_Test()
        {
            var result = new Recursion().Calculate2(3, 3);
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void MinCoins_Test()
        {
            Recursion r = new Recursion();
            r.max = r.coins1.Keys.Max();
            var result = r.MinCoins(8, 0);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinCoinsI_Test()
        {
            Recursion r = new Recursion();
            r.max = r.coins1.Keys.Max();
            var result = r.MinCoinsI(6);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ReverseString()
        {
            var result = new Functional().ReverseOddIndexedChar_I("Python");
            Assert.AreEqual("yhnotP", result);
        }

        [TestMethod]
        public void ReverseString_Functional()
        {
            var result = new Functional().ReverseOddIndexedChar("ISI");
            Assert.AreEqual("SII", result);
        }

        [TestMethod]
        public void ReverseOddIndexedString()
        {
            var result = new Functional().ReverseOddIndexedString("Python Is Truly Interesting Programming Language");
            Assert.AreEqual("yhnotP Xs rlyuT Xntxrxstxng rgamngimroP Lxngxxgx", result);
        }

        [TestMethod]
        public void ReverseOddIndexedString2()
        {
            var result = new Functional().ReverseOddIndexedString("God Is Good And Bad");
            Assert.AreEqual("odG Xs odoG Xnd adB", result);
        }

        [TestMethod]
        public void ReverseOddIndexedString3()
        {

            var s = "God Is Good And Bad";
            var odds = s.ReverseOddIndexedString();
            var evens = s.ReplaceVowelsInEvenIndexedString();
            var join = odds.Zip(evens, (o, e) => o + " " + e);

            //zip only matches equal number of values in both collections            
            var result = s.Length % 2 == 1 ? (String.Join(" ", join) + " " + odds.Last().Trim()) :
                String.Join(" ", join).Trim();

            Assert.AreEqual("odG Xs odoG Xnd adB", result);
        }

        [TestMethod]
        public void BuyChocolates_Test()
        {

            // var n = Convert.ToInt64 (Console.ReadLine ());
            // var c = Console.ReadLine ().Split (',');

            // Dictionary<long, long> chocolates = new Dictionary<long, long> ();
            // for (long i = 0; i < c.Length; i++) {
            //     var s = c[i].Split (':');
            //     chocolates.Add (Convert.ToInt64 (s[2]), Convert.ToInt64 (s[1]));
            // }
            // var price = BuyChocolates (chocolates, n);
            // Console.WriteLine (price);

            SortedDictionary<int, int> chocolates = new SortedDictionary<int, int>
            {
                [30] = 2,
                [15] = 8
            };

            var price = new RandomProblems().BuyChocolates(chocolates, 5);
            Assert.AreEqual(75, price);

        }

        [TestMethod]
        public void XSeries_Test()
        {
            var str = "11, 5, 19, 2, 8, 3, 4";
            var input = str.Split(',').Select(Int32.Parse).ToList();
            var result = new RandomProblems().XSeries(input);
            var r = String.Join(',', result);
            var result1 = new RandomProblems().XSeries(new List<int> { 67, 32, 1 });

            //new RandomProblems ().XSeries (new List<int> { 1, 2, 3, 3, 2 ,4});
            //var result = new RandomProblems ().XSeries (new List<int> { 1,2,3 });
            //Assert.IsTrue (true);
        }

        [TestMethod]
        public void DecodeMessage_Test()
        {
            var decode = new RandomProblems().DecodeMessage_R("123", 3);
            Assert.AreEqual(3, decode);
        }

        [TestMethod]
        public void Fib_Memo_Test()
        {
            long n = 8;
            long?[] memo = new long?[n + 1];
            memo[0] = 1;
            memo[1] = 1;
            for (int i = 1; i < memo.Length; i++)
            {
                memo[i] = null;
            }
            var result = new RandomProblems().Fib_Memo(8, memo);
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void BalanceAmount()
        {
            // var result = new RandomProblems().BalanceAmount(new int[]{2,3,5,10},10,0, new Dictionary<string, long>());
            var result = new RandomProblems().BalanceAmount(new int[] { 1, 2 }, 3, 0, new Dictionary<string, long>());
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void MaximizeProfit_Test()
        {
            RandomProblems r = new RandomProblems();
            long result = 0;
            // result = r.MaximizeProfit (new int[] { 10, 100, 20, 30, 40, 50 });
            // Console.WriteLine (result);
            // Assert.AreEqual (result, 120);
            // result = r.MaximizeProfit (new int[] { 30, 42, 25, 85, 100, 70, 110 });
            // Console.WriteLine (result);
            // Assert.AreEqual (result, 127);
            result = r.MaximizeProfit(new int[] { 5, 10, 8, 30, 25, 35, 10, 50 });
            Console.WriteLine(result);
            Assert.AreEqual(result, 75);
        }


        [TestMethod]
        public void BinarySort_Test()
        {
            var r = new Recursion().BubbleSort_I(new int[] { 3, 2, 1, 5, 7, 0 });
            Assert.AreEqual(2, r[2]);
        }

        [TestMethod]
        public void Bubblesort_I_Test()
        {
            var r = new Recursion().BubbleSort_I(new int[] { 3, 2, 1 });
            Assert.AreEqual(3, r[2]);
        }

        [TestMethod]
        public void Bubblesort_R_Test()
        {
            var r = new Recursion().BubbleSort_R(new int[] { 3, 2, 1, 8, 9, 0, 100, 1001 }, 0);
            Assert.AreEqual(1001, r[7]);
        }

        [TestMethod]
        public void fn_Test()
        {
            int[] coins = new int[] { 4, 5, 9 };

            var r = CoinChange.fn(1, coins);
            Assert.AreEqual(0, r);

            r = CoinChange.fn(2, coins);
            Assert.AreEqual(0, r);

            r = CoinChange.fn(3, coins);
            Assert.AreEqual(0, r);

            r = CoinChange.fn(5, coins);
            Assert.AreEqual(1, r);

            r = CoinChange.fn(4, coins);
            Assert.AreEqual(1, r);

            r = CoinChange.fn(9, coins);
            Assert.AreEqual(1, r);

            r = CoinChange.fn(29, coins);
            Assert.AreEqual(0, r);
        }
        [TestMethod]
        public void DisjointSets()
        {

            List<int[]> sets = new List<int[]>{
                new int[]{1,6},
                new int[]{2,7},
                new int[]{3,8},
                new int[]{4,9},
                new int[]{2,6}
            };
            var rank = new GraphTheory().Union(sets, 10);
            Assert.AreEqual(2, rank[0]);
            Assert.AreEqual(4, rank[1]);
            List<int[]> sets1 = new List<int[]>{
                new int[]{1,17},
                new int[]{5,13},
                new int[]{7,12},
                new int[]{5,17},
                new int[]{5,12},
                new int[]{2,17},
                new int[]{1,18},
                new int[]{8,13},
                new int[]{2,15},
                new int[]{5,20},
            };
            rank = new GraphTheory().Union(sets1, 20);
            Assert.AreEqual(11, rank[0]);
            Assert.AreEqual(11, rank[1]);

        }
        Dictionary<int, Node> vertices = new Dictionary<int, Node>();
        [TestMethod]
        public void RandomTests()
        {
            
            vertices.Add(1, new Node(-1, 0));
            vertices.Add(2, new Node(1, 2));
            vertices.Add(3, new Node(2, 3));
            vertices.Add(4, new Node(1, 6));
            vertices.Add(5, new Node(2, 5));

            int wt =0;            

            for(int i=1;i<6;i++){
                for(int j=i+1;j<6;j++){
                    wt += GetWeight(j);   
                }
            }
        }

        public int GetWeight(int n){
            int wt=0;
            while(vertices[n].Parent != -1 ){

                wt+= vertices[n].Weight;
                n = vertices[n].Parent;
            }
            return wt;
        }

        public class Node
        {
            public int Parent { get; set; }
            public int Weight { get; set; }

            public Node(int p, int w)
            {
                this.Parent = p;
                this.Weight = w;
            }
        }

        [TestMethod]
        public void MST()
        {
            GraphTheory g = new GraphTheory();
            int[,] input = new int[6, 6];
            input[1, 2] = 2;
            input[2, 1] = 2;
            input[1, 4] = 6;
            input[4, 1] = 6;
            input[2, 3] = 3;
            input[3, 2] = 3;
            input[2, 4] = 8;
            input[4, 2] = 8;
            input[2, 5] = 5;
            input[5, 2] = 5;
            input[3, 5] = 7;
            input[5, 3] = 7;
            input[4, 5] = 9;
            input[5, 5] = 9;
            //var g = d.BuildGraph(input, 5);
            Assert.AreEqual(16, g.MST(input, 5));

        }

        [TestMethod]
        public void MST1()
        {
            GraphTheory g = new GraphTheory();
            int[,] input = new int[6, 6];
            input[1, 2] = 8;
            input[2, 1] = 8;
            input[1, 3] = 32;
            input[3, 1] = 32;
            input[2, 3] = 2;
            input[3, 2] = 2;
            input[2, 4] = 4;
            input[4, 2] = 4;
            input[3, 4] = 16;
            input[4, 3] = 16;
            input[4, 5] = 1;
            input[5, 5] = 1;
            //var gt = g.BuildGraph(input, 5);
            Assert.AreEqual(15, g.MST(input, 5));

        }
        [TestMethod]
        public void Subsequence_Test(){
            var s = Set.GetAllSubsequence(new int[]{1,2,3});
        }

         [TestMethod]
        public void CutRod_Test(){
            var s = RandomProblems.cutRod(new int[] {1, 5, 8, 9, 10, 17, 17, 20},8);
        }


    }
}