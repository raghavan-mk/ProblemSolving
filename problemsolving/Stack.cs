using System;
using System.Collections.Generic;

namespace ProblemSolving {
    public class Stack {
        public void StackIt (string[] args) {
            int n = Convert.ToInt32 (args[0]);
            int max = Int32.MinValue;
            Stack<int> stack = new Stack<int> ();
            for (int i = 0; i < n; i++) {
                var t = args[i].Split (' ');
                if (Convert.ToInt32 (t[0]) == 1) {
                    var t1 = Convert.ToInt32 (t[1]);
                    if (t1 > max)
                        max = t1;
                    stack.Push (t1);
                } else if (Convert.ToInt32 (t[0]) == 2) {
                    var pop = stack.Peek ();
                    if (pop == max)
                        max = Int32.MinValue;
                    stack.Pop ();
                } else if (Convert.ToInt32 (t[0]) == 3) {
                    if (max == Int32.MinValue) {
                        foreach (int t3 in stack)
                            if (t3 > max) max = t3;
                    }
                    Console.WriteLine (max);
                }
            }
        }
    }
}