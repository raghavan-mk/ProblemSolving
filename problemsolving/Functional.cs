using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving {

    public static class StringExtn {
        public static IEnumerable<String> ReverseOddIndexedString (this String s) =>
            s.Split (' ')
            .Where ((s1, i) => i % 2 == 0)
            .Select (s2 => s2.ReverseOddIndexedChar ());

        public static IEnumerable<String> ReplaceVowelsInEvenIndexedString (this String s) =>
            s.Split (' ')
            .Where ((s1, i) => i % 2 == 1)
            .Select (s2 => String.Concat (s2.Select (s3 => s3.ReplaceVowel ())));

        public static string ReverseOddIndexedChar (this String s) {
            var odds = String.Concat (s.Where ((c, i) => i % 2 == 0));
            var evens = String.Concat (s.Where ((c, i) => i % 2 == 1));
            return String.Concat (evens, String.Concat (odds.Reverse ()));
        }

        public static char ReplaceVowel (this char c) 
            => "AEIOU".Contains (c) ? 'X' : "aeiou".Contains (c) ? 'x' : c;

    }
    public class Functional {

        public string ReverseOddIndexedString (string s) {

            var odds = s.Split (' ')
                .Where ((s1, i) => i % 2 == 0)
                .Select (s2 => ReverseOddIndexedChar (s2));

            var evens = s.Split (' ')
                .Where ((s1, i) => i % 2 == 1)
                .Select (s2 => String.Concat (s2.Select (s3 => ReplaceVowel (s3))));

            var join = odds.Zip (evens, (o, e) => o + " " + e);

            //zip only matches equal number of values in both collections            
            return s.Length % 2 == 1 ? (String.Join (" ", join) + " " + odds.Last ().Trim ()) :
                String.Join (" ", join).Trim ();

        }

        public char ReplaceVowel (char c) => "AEIOU".Contains (c) ? 'X' : "aeiou".Contains (c) ? 'x' : c;

        public string ReverseOddIndexedChar (string s) {

            var odds = String.Concat (s.Where ((c, i) => i % 2 == 0));
            var evens = String.Concat (s.Where ((c, i) => i % 2 == 1));
            return String.Concat (evens, String.Concat (odds.Reverse ()));
        }

        public string ReverseOddIndexedChar_I (string s) {

            string evens = "";
            string odds = "";

            for (int i = 0; i < s.Length; i++) {
                if (i % 2 == 0) {
                    odds += s[i];
                } else {
                    evens += s[i];
                }
            }
            return evens + String.Concat (odds.Reverse ());
        }
    }
}