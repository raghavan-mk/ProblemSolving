using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving
{
    //Given an array of N integers, write a program to remove K elements from it such that there are minimum number of unique integers left in the array and print the number of unique integers.
    // Sample Input	Sample Output	Explanation
    // 3,10
    // 1,2,3,3,4,4,5,5,6,6	4	After removing 1, 2, 3 from the input, 3,4,4,5,5,6,6 will be left in the array. Hence the unique elements left in the array are 3,4,5,6. Hence the count is 4.

    public class RandomProblems
    {
        public int DistinctElements(int skip, int length, List<int> elements)
        {

            Dictionary<int, int> count = new Dictionary<int, int>();

            elements.ForEach(e =>
            {

                if (count.ContainsKey(e))
                {
                    var c = count[e];
                    count[e] = ++c;
                }
                else
                    count.Add(e, 1);

            });

            return count.OrderBy(i => i.Value)
                .SkipWhile(i => i.Value == 1)
                .Distinct()
                .Count();
        }
        public long FibI(long n)
        {

            long n1 = 1;
            long n2 = 1;

            for (long i = 3; i < n; i++)
            {
                var nxt = n2 + n1;
                n1 = n2;
                n2 = nxt;
            }
            return n2;
        }

        public long PrimFibISum(long n, long min, long max)
        {

            if (n == 0 || n == 1) return 0;
            if (n == 2) return 1;
            if (n == 3) return 2;

            long primesSum = 0;
            long n1 = 0;
            long n2 = 1;

            for (long i = 2; i < n; i++)
            {
                var nxt = n2 + n1;
                n1 = n2;
                n2 = nxt;

                if (n2 >= min && n2 <= max)
                {
                    if (IfPrime(n2))
                    {
                        Console.WriteLine(n2);
                        primesSum += n2;
                    }
                }
            }
            return primesSum;
        }

        public bool IfPrime(long n)
        {
            long i = 2;

            if (n == 1) return true;
            if (n == 2) return true;

            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                    return false;
                else
                    i++;
            }
            return true;

        }
        //         Buying Show Tickets 
        // A line has formed to buy tickets for a concert. 
        // In order to delay a shortage caused by brokers buying large blocks of tickets, venue management has decided to sell only one ticket at a time. 
        // Buyers have to wait through the line again if they want to buy more tickets.  Jesse is standing in line and has a number of tickets to purchase.
        // Given a list of ticket buyers with their numbers of desired tickets, determine how long it will take Jesse to purchase his tickets. 
        // Jesse's position in line will be stated, and each transaction takes 1 unit of time.  
        // For your purposes, no time is spent moving to the back of the line.
        // e.g. 5,5,2,3; Jesse is last, expected output : 11
        // 2,6,3,4,5; Jesse is in middle, expected output: 12

        public int TicketBuyersQueue(int[] elements, int pos)
        {

            Queue<TicketBuyer> buyersQueue = new Queue<TicketBuyer>();
            int totalTurn = 0;

            for (int i = 0; i < elements.Length; i++)
            {

                TicketBuyer buyer = new TicketBuyer();
                buyer.Name = i == pos ? "Jesse" : i.ToString();
                buyer.Tickets = elements[i];
                buyersQueue.Enqueue(buyer);
            }

            while (true)
            {

                totalTurn++;
                var b = buyersQueue.Dequeue();
                b.Tickets = --b.Tickets;

                if (b.Tickets == 0 && b.Name == "Jesse")
                    return totalTurn;

                else if (b.Tickets != 0)
                    buyersQueue.Enqueue(b);

            }
        }

        //Buy chocolates

        // Uncle Mark wants to buy the costliest chocolate
        // for all the kids.The kids demand
        // for the same chocolate.The stock availability of chocolates, S in a store and the number of kids, N are given.Write a program to print the amount required to buy the chocolates.Print 0
        // if sufficient stock doesn’ t exist.

        // Input Format

        // First line contains the number of kids N and the second line contains the stock availability details S details in the format chocolatename : price : quantityavailable separated by comma.Read the input from the standard input stream

        // Sample Input Sample Output Explanation
        // 5
        // Kinder : 30 : 2, Cadbury : 15 : 8 75‘ Kinder’ is the costliest chocolate but it is not sufficient
        // for all the children.Hence, ‘Cadbury’ is the next costliest chocolate which can be bought
        // for all the children.Hence the amount needed is 75.

        public int BuyChocolates(SortedDictionary<int, int> chocolates, int n)
        {
            for (int i = chocolates.Count() - 1; i >= 0; i--)
            {
                var max = chocolates.ElementAt(i);
                if (max.Value >= n)
                    return max.Key * n;
            }
            return 0;
        }

        public HashSet<long> Fib(long n)
        {
            long prev = 1;
            long curr = 2;
            HashSet<long> fib = new HashSet<long> { prev, curr };

            while (true)
            {
                var next = prev + curr;
                fib.Add(next);
                if (next >= n)
                {
                    return fib;
                }
                prev = curr;
                curr = next;
            }
        }

        // Given a list of natural numbers, write a program to:
        // Print the list having the highest number of elements that forms the X - series.
        // In case ofmultiple lists having the highest number of elements that forms the X - series, print the unique elements from all the lists that should form another X - series.
        // Print - 1, if X - series cannot be formed.
        // X - Series: Xi = X (i - 1) + X (i - 2); where i is the index of the list.

        // Sample Input Sample Output Explanation
        // 11,5,19,2,8,3,4 Unique list of numbers forming 
        // X - Series sequence are: (2, 3, 5), (3, 5, 8), (3, 8, 11), (8, 11, 19), (2, 3, 5, 8), (3, 8, 11, 19) 
        // List with the highest number of elements are (2, 3, 5, 8), (3, 8, 11, 19) 
        // Corresponding elements in both the lists are sorted in ascending order 
        // and hence the first list element is (2, 3, 5, 8) 
        // 67, 32, 1 - 1 Using the given set of numbers, no X - Series sequence can be formed and hence - 1

        public List<int> XSeries(List<int> list1)
        {

            if (list1.Count < 3)
                return new List<int> { -1 };

            list1.Sort();
            var list = list1.Distinct().ToList();

            double totalSubsets = Math.Pow(2, list.Count);

            // for (int i = 1; i <= count - 1; i++) {
            //     string str = Convert.ToString (i, 2).PadLeft (list.Count, '0');
            //     for (int j = 0; j < str.Length; j++) {
            //         if (str[j] == '1') {
            //             Console.Write (list[j]);
            //         }
            //     }
            //     Console.WriteLine ();
            // }
            List<List<int>> motherList = new List<List<int>>();

            for (int i = 0; i < totalSubsets; i++)
            {
                List<int> childList = new List<int>();
                for (int j = 0; j < list.Count; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        childList.Add(list[j]);
                    }
                }
                motherList.Add(childList);
            }

            var fibList = motherList.Where(c => c.Count >= 3).ToList();

            for (int i = fibList.Count - 1; i >= 0; i--)
            {
                var f = fibList[i];
                var prev = f[0];
                var curr = f[1];
                for (int j = 2; j < f.Count; j++)
                {
                    if (f[j] != prev + curr)
                    {
                        fibList.Remove(f);
                        break;
                    }
                    prev = curr;
                    curr = f[j];
                }
            }

            if (fibList.Count == 0)
                return new List<int> { -1 };

            var max = fibList.Max(x => x.Count);
            var fibLists = fibList.Where(x => x.Count >= max).ToList();
            return fibLists[0];

            // var fibNums = fibLists.SelectMany (x => x).Distinct ().ToList ();
            // var prev1 = fibNums[0];
            // var curr1 = fibNums[1];

            // List<int> fibNumFinal = new List<int> { prev1, curr1 };

            // for (int i = 2; i < fibNums.Count; i++) {
            //     var next1 = prev1 + curr1;
            //     if (fibNums[i] == next1) {
            //         fibNumFinal.Add (fibNums[i]);
            //         prev1 = curr1;
            //         curr1 = fibNums[i];
            //     } else
            //         return fibNumFinal;
            // }

            // return new List<int> {-1 };
        }

        Dictionary<string, string> messages = new Dictionary<string, string>
        {
            ["1"] = "a",
            ["2"] = "b",
            ["3"] = "c",
            ["12"] = "l"
        };
        public int DecodeMessage_R(string data, int k, int[] memo = null)
        {
            if (k == 0)
                return 1;
            var s = data.Length - k;
            if (data[s] == '0')
                return 0;
            // if (memo[k] != null)
            //     return memo[k];

            var result = DecodeMessage_R(data, k - 1);

            if (k >= 2 && s <= data.Length - 2 && Convert.ToInt16(data.Substring(s, 2)) <= 26)
                result += DecodeMessage_R(data, k);

            return result;

        }

        public int DecodeMessage_I(string data)
        {
            int decode = 1;
            if (data.Length == 0)
                return decode;
            for (int i = 0; i < data.Length - 1; i++)
            {
                var s = data.Substring(i, 2);
                if (Convert.ToInt16(s) <= 26)
                    ++decode;
            }
            return decode;
        }

        public long Fib_Memo(long n, long?[] memo)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            if (memo[n] == null)
                memo[n] = Fib_Memo(n - 1, memo) + Fib_Memo(n - 2, memo);

            return memo[n].Value;
        }

        //Balance Amount
        // John is travelling in a bus.While buying the ticket, he realizes that he doesn’ t have the exact amount.So he requests the conductor to
        // return the balance.Given the balance amount to be returned and the valid denominations, write a program to print the number of ways in which the balance amount can be returned assuming the conductor has infinite number of such valid denominations.

        // Input format:
        //     The first line gives the balance amount to be returned.The second line gives the valid denominations, each denomination separated by a comma.Read the input from standard input.

        // Output format:
        //     Print the number of ways in which balance can be returned to the standard output.

        // 10
        // 2, 3, 5, 10 5 The possible ways in which balance can be returned are: (2 2 2 2 2), (2 2 3 3), (2 3 5), (5 5), (10) Hence the output is 5.

        // https://www.youtube.com/watch?v=sn0DWI-JdNA&feature=youtu.be
        public long BalanceAmount(int[] coins, int amount, int index, Dictionary<string, long> memo)
        {

            if (amount == 0)
                return 1;
            if (index >= coins.Length)
                return 0;
            string key = amount + "_" + index;
            if (memo.ContainsKey(key))
                return memo[key];
            long noOfWays = 0;
            int amountWithCoins = 0;

            while (amountWithCoins <= amount)
            {
                var rem = amount - amountWithCoins;
                noOfWays += BalanceAmount(coins, rem, index + 1, memo);
                amountWithCoins += coins[index];
            }
            memo.Add(key, noOfWays);
            return noOfWays;
        }

        //Share Market

        //In an intra-day share market, a user usually buys a share and tries to sell the same share to get high profit on the same day. They can buy a new share only after selling the existing (i.e. if user has already bought 1 share, he has to sell it before buying the same share again)
        // Given a list of prices for the share at different points of time in a single day, write a program to print the maximum profit the user can make by buying and selling that share.
        // Note: The user can buy and sell the same share at any point of time, but at most thrice in a day (i.e maximum transaction can be 3) and No negative values will be in the input list
        // For example, consider the share prices at different points of time as below:
        // 30,42,25,85,100,70,110
        // Solution:
        // Buying Price 30 25 70 
        // Selling Price 42 100 110
        // Profit 12 75 40

        // Input format: 10,100,20,30,40,50
        // Share prices at different points of time, separated by comma, is given. Read the input from standard input.
        // Output format: 120
        // Print the maximum profit possible to the standard output.

        public long ProfitFromSellingShares(int[] shares){
            return 0;
        }
    }
}

public class TicketBuyer
{
    public string Name { get; set; }
    public int Tickets { get; set; }
}