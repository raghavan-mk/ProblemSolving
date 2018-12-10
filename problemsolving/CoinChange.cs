using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving {
    public class CoinChange {
        public static int[] GetChange (int[] coins, int sum) {

            int[] minCoinsNeeded = new int[sum];

            minCoinsNeeded[0] = 0;

            for (int i = 1; i < minCoinsNeeded.Length; i++) {
                minCoinsNeeded[i] = Int32.MaxValue;
            }

            for (int i = 1; i < minCoinsNeeded.Length; i++) {
                for (int j = 0; j < coins.Length; j++) {
                    if (coins[j] <= i && minCoinsNeeded[i - coins[j]] < minCoinsNeeded[i])
                        minCoinsNeeded[i] = minCoinsNeeded[i - coins[j]] + 1;

                }
            }

            return minCoinsNeeded;
        }

        public static string CoinChangeR (int amount, int[] coins) {

            Console.WriteLine ($"Amount {amount} to be given");

            var coin_chosen = 0;

            if (coins.Contains (amount))
                return amount.ToString ();

            for (var i = 0; i < coins.Length; i++) {
                if (coins[i] < amount)
                    coin_chosen = coins[i];
                else if (coins[i] > amount)
                    continue;
                // else
                //     break;
            }

            Console.WriteLine ($"Coins Chosen {coin_chosen}");

            var remaining_change = amount - coin_chosen;

            Console.WriteLine ($"Amount remaining {remaining_change}");

            return "" + coin_chosen + "," + CoinChangeR (remaining_change, coins);

        }
    }
}