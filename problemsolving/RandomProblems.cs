using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving {
    //Given an array of N integers, write a program to remove K elements from it such that there are minimum number of unique integers left in the array and print the number of unique integers.
    // Sample Input	Sample Output	Explanation
    // 3,10
    // 1,2,3,3,4,4,5,5,6,6	4	After removing 1, 2, 3 from the input, 3,4,4,5,5,6,6 will be left in the array. Hence the unique elements left in the array are 3,4,5,6. Hence the count is 4.

    public class RandomProblems {
        public int DistinctElements (int skip, int length, List<int> elements) {

            Dictionary<int, int> count = new Dictionary<int, int> ();

            elements.ForEach (e => {

                if (count.ContainsKey (e)) {
                    var c = count[e];
                    count[e] = ++c;
                } else
                    count.Add (e, 1);

            });

            return count.OrderBy (i => i.Value)
                .SkipWhile (i => i.Value == 1)
                .Distinct ()
                .Count ();
        }
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
                        Console.WriteLine (n2);
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
        //         Buying Show Tickets 
        // A line has formed to buy tickets for a concert. 
        // In order to delay a shortage caused by brokers buying large blocks of tickets, venue management has decided to sell only one ticket at a time. 
        // Buyers have to wait through the line again if they want to buy more tickets.  Jesse is standing in line and has a number of tickets to purchase.
        // Given a list of ticket buyers with their numbers of desired tickets, determine how long it will take Jesse to purchase his tickets. 
        // Jesse's position in line will be stated, and each transaction takes 1 unit of time.  
        // For your purposes, no time is spent moving to the back of the line.
        // e.g. 5,5,2,3; Jesse is last, expected output : 11
        // 2,6,3,4,5; Jesse is in middle, expected output: 12

        public int TicketBuyersQueue (int[] elements, int pos) {

            Queue<TicketBuyer> buyersQueue = new Queue<TicketBuyer> ();
            int totalTurn = 0;

            for (int i = 0; i < elements.Length; i++) {

                TicketBuyer buyer = new TicketBuyer ();
                buyer.Name = i == pos ? "Jesse" : i.ToString ();
                buyer.Tickets = elements[i];
                buyersQueue.Enqueue (buyer);
            }

            while (true) {

                totalTurn++;
                var b = buyersQueue.Dequeue ();
                b.Tickets = --b.Tickets;

                if (b.Tickets == 0 && b.Name == "Jesse")
                    return totalTurn;

                else if (b.Tickets != 0)
                    buyersQueue.Enqueue (b);

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

        public int BuyChocolates (Dictionary<int, int> chocolates, int n) =>
            chocolates.FirstOrDefault (k => k.Key >= n).Value * n;

        // Given a list of natural numbers, write a program to:
        // Print the list having the highest number of elements that forms the X - series.
        // In case ofmultiple lists having the highest number of elements that forms the X - series, print the unique elements from all the lists that should form another X - series.
        // Print - 1, if X - series cannot be formed.
        // X - Series: Xi = X (i - 1) + X (i - 2); where i is the index of the list.

        // Sample Input Sample Output Explanation
        // 11, 5, 19, 2, 8, 3, 4 2, 3, 5, 8 Unique list of numbers forming 
        // X - Series sequence are: (2, 3, 5), (3, 5, 8), (3, 8, 11), (8, 11, 19), (2, 3, 5, 8), (3, 8, 11, 19) 
        // List with the highest number of elements are (2, 3, 5, 8), (3, 8, 11, 19) 
        // Corresponding elements in both the lists are sorted in ascending order 
        // and hence the first list element is (2, 3, 5, 8) 
        // 67, 32, 1 - 1 Using the given set of numbers, no X - Series sequence can be formed and hence - 1

        public List<int> XSeries(List<int> input){
            input.Sort();
            List<List<int>> fib = new List<List<int>>();
            for(int i=0;i<input.Count;i++){
                var current = input[i];
            }
            return null;
        }

    }
}

public class TicketBuyer {
    public string Name { get; set; }
    public int Tickets { get; set; }
}