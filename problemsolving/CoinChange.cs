using System;

namespace ProblemSolving
{
    public class CoinChange
    {
        public static int[] GetChange(int[] coins, int sum){


            int[] minCoinsNeeded = new int[sum];

            minCoinsNeeded[0] = 0;

            for (int i = 1; i < minCoinsNeeded.Length; i++) {
                minCoinsNeeded[i] = Int32.MaxValue;
            }

            for (int i = 1; i < minCoinsNeeded.Length; i++) {
                for (int j = 0; j < coins.Length; j++) {
                    if(coins[j] <= i && minCoinsNeeded[i-coins[j]] < minCoinsNeeded[i])
                        minCoinsNeeded[i] = minCoinsNeeded[i-coins[j]] + 1;
                  
                }
            }

            return minCoinsNeeded;
        }

        
    }
}