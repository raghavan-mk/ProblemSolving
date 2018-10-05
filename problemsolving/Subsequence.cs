using System;
using System.Text;

namespace ProblemSolving {

    ///Get all subsets from a set - subsequencing
    ///get all sub arrays

    public class Set {

        public static long GetSumOfAllSubsequence (int[] set) {
            long result = 0;
            double totalSubsets = Math.Pow (2, set.Length);

            for (int i = 0; i < totalSubsets; i++) {
                for (int j = 0; j < set.Length; j++) {
                    if ((i & (1 << j)) != 0) {
                        result += set[j];
                    }
                }
            }

            return result;
        }

        public static string GetAllSubsequences_1 (int[] set) {

            StringBuilder subseq = new StringBuilder ();

            for (int i = 0; i < set.Length; i++) {
                for (int j = i; j < set.Length; j++) {
                    for(int k=i;k<=j;k++){
                        //set[k]
                    }

                }
            }

            return subseq.ToString ();
        }
        public static long[] Get_Max_Subarray_SubSeq (int[] set) {

            long[] result = new long[2];
            long curr_max = set[0];
            long max_subarr = set[0];
            long max_subseq = set[0];

            for (int i = 1; i < set.Length; i++) {
                max_subseq = Math.Max (max_subseq, Math.Max (set[i], max_subseq + set[i]));
                curr_max = Math.Max (set[i], curr_max + set[i]);
                max_subarr = Math.Max (max_subarr, curr_max);
            }
            result[0] = max_subarr;
            result[1] = max_subseq;
            return result;

        }
        public static int GetMaxSubArray (int[] set) {

            int max_ending_here = set[0];
            int max_so_far = set[0];

            for (int i = 1; i < set.Length; i++) {
                max_ending_here = Math.Max (set[i], max_ending_here + set[i]);
                max_so_far = Math.Max (max_so_far, max_ending_here);
            }
            return max_so_far;
        }

        public static string GetAllSubsequence (int[] set) {
            long minVal = -9999999999;
            var totalSubSets = Math.Pow (2, set.Length);
            StringBuilder subSets = new StringBuilder ();
            long maxSubSeqCount = minVal;

            for (int i = 0; i < totalSubSets; i++) {
                long tempMax = 0;
                bool valSet = false;
                for (int j = 0; j < set.Length; j++) {
                    if ((i & (1 << j)) != 0) {
                        tempMax += set[j];
                        subSets.Append (set[j] + " ");
                        valSet = true;
                    }
                }
                if (valSet && tempMax > maxSubSeqCount)
                    maxSubSeqCount = tempMax;

                subSets.AppendLine ();
            }
            Console.WriteLine (maxSubSeqCount);
            return subSets.ToString ();
        }

        public static string GetSubArray (int[] set) {
            var seqLen = (set.Length * (set.Length + 1)) / 2;
            StringBuilder subArr = new StringBuilder ();
            long maxSubArrSum = -9999999999;
            long tempMax = 0;

            for (int i = 0; i < set.Length; i++) {
                bool valSet = false;
                for (int j = i; j < set.Length; j++) {
                    for (int k = i; k <= j; k++) {
                        tempMax += set[k];
                        subArr.Append (set[k]);
                        subArr.Append (" ");
                        valSet = true;
                    }
                    if (valSet && tempMax > maxSubArrSum)
                        maxSubArrSum = tempMax;
                    tempMax = 0;
                    subArr.AppendLine ();
                }

            }
            Console.WriteLine (maxSubArrSum);
            return subArr.ToString ();
        }
    }
}