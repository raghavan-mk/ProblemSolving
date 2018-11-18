using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving {
    class Program {
        static void Main (string[] args) {
            //CoinChange_Test();
            // Subsequence_Test();
            // SubArray_Test ();
            // MaxSubArray_Test ();
            //GetSumOfAllSubsequence();
            //LinkedList_AddNode();
            //LinkedList_AddNode_AtEnd ();
            var head = SinglyLinkedList.LinkedList_Test(new int[]{1,2,3,4,5});
            for(;head!=null;head=head.next){
                Console.WriteLine(head.data);
            }
        }

        static void CoinChange_Test () {
            var result = CoinChange.GetChange (new int[] { 1, 3, 5 }, 11);
            result.ToList ().ForEach (r => Console.Write (r));
        }

        static void Subsequence_Test () {
            // var result = Set.GetAllSubsequence (new int[] {-2, -3, -1, -4, -6 });
            // var result1 = Set.GetAllSubsequence (new int[] { 1, 2, 3, 4 });
            // var result2 = Set.GetAllSubsequence (new int[] {-1, 2, 3, -4, 5, 10 });
            //var result3 = Set.GetAllSubsequence (new int[] { 2, -1, 2, 3, 4, -5 });
            var result3 = Set.GetAllSubsequence (new int[] { 1, 2, 3 });
            result3.ToList ().ForEach (r => Console.Write (r));
        }

        static void SubArray_Test () {
            // var result = Set.GetSubArray (new int[] {-2, -3, -1, -4, -6 });
            // var result1 = Set.GetSubArray (new int[] { 1, 2, 3, 4 });
            // var result2 = Set.GetSubArray (new int[] {-1, 2, 3, -4, 5, 10 });
            // var result3 = Set.GetSubArray (new int[] { 2, -1, 2, 3, 4, -5 });
            // var result4 = Set.GetSubArray (new int[] { 1, 2, 3 });
            // result2.ToList ().ForEach (r => Console.Write (r));
        }
        static void MaxSubArray_Test () {
            var result = Set.GetMaxSubArray (new int[] {-2, -3, -1, -4, -6 });
            Console.WriteLine (result);
            var result1 = Set.GetMaxSubArray (new int[] { 1, 2, 3, 4 });
            Console.WriteLine (result1);
            var result2 = Set.GetMaxSubArray (new int[] {-1, 2, 3, -4, 5, 10 });
            Console.WriteLine (result2);
            var result3 = Set.GetMaxSubArray (new int[] { 2, -1, 2, 3, 4, -5 });
            Console.WriteLine (result3);
            var result4 = Set.GetMaxSubArray (new int[] { 1, 2, 3 });
            Console.WriteLine (result4);
            var result5 = Set.GetMaxSubArray (new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine (result5);

        }

        static void GetSumOfAllSubsequence () {
            Console.WriteLine (Set.GetSumOfAllSubsequence (new int[] { 6, 5, 8 }));
            // Console.WriteLine(Set.GetSumOfAllSubsequence(new int[]{1,2}));

        }

        static void LinkedList_AddNode () {
            SinglyLinkedListNode head = new SinglyLinkedListNode (10);
            head = SinglyLinkedList.InsertNodeAtEnd (head, 20);
            head = SinglyLinkedList.InsertNodeAtEnd (head, 30);
            head = SinglyLinkedList.InsertNodeAtEnd (head, 60);
            head = SinglyLinkedList.InsertNodeAtEnd (head, 70);
            head = SinglyLinkedList.InsertNodeAtEnd (head, 40);
            head = SinglyLinkedList.InsertNodeAtEnd (head, 50);            

            for (var h = head; h != null; h = h.next) {
                Console.WriteLine (h.data);
            }

        }

        static void LinkedList_AddNode_AtEnd(){
            var list = SinglyLinkedList.InsertNodeAtBeginning(new int[]{1,2,3,4});
            for(;list!=null;list = list.next){
                Console.WriteLine(list.data);
            }
        }

        static void StackIt(){
            string[] numbers = new string[]{"1"};
            new ProblemSolving.Stack().StackIt(numbers);
        }
    }
}