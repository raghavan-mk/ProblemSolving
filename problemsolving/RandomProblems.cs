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
                if (i == pos) {
                    buyer.Name = "Jesse";
                    buyer.Tickets = elements[i];
                } else {
                    buyer.Name = i.ToString ();
                    buyer.Tickets = elements[i];
                }

                buyersQueue.Enqueue (buyer);
            }

            while (true) {

                totalTurn++;
                var b = buyersQueue.Dequeue();
                b.Tickets = --b.Tickets;

                 if(b.Tickets == 0 && b.Name == "Jesse")
                    return totalTurn;

                if(b.Tickets != 0)
                    buyersQueue.Enqueue(b);            

            }           

        }
    }
}

public class TicketBuyer {
    public string Name { get; set; }
    public int Tickets { get; set; }
}