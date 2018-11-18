using System;
using System.IO;

namespace ProblemSolving {
    public class LinkedList {
        public static SinglyLinkedListNode removeDuplicates (SinglyLinkedListNode head) {
            return head;

        }

        public static void LinkedList_Main () {

            // TextWriter textWriter =
            //     new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

            int t = Convert.ToInt32 (Console.ReadLine ());

            for (int tItr = 0; tItr < t; tItr++) {
                SinglyLinkedList llist = new SinglyLinkedList ();

                int llistCount = Convert.ToInt32 (Console.ReadLine ());

                for (int i = 0; i < llistCount; i++) {
                    int llistItem = Convert.ToInt32 (Console.ReadLine ());
                    llist.InsertNode (llistItem);
                }

                SinglyLinkedListNode llist1 = removeDuplicates (llist.head);

                PrintSinglyLinkedList (llist1, " ", (o) => Console.WriteLine (o));

            }

        }

        static void PrintSinglyLinkedList (SinglyLinkedListNode node, string sep,
            Action<object> print) {
            while (node != null) {
                print (node.data);

                node = node.next;

                if (node != null) {
                    print (sep);
                }
            }
        }
    }

}

public class SinglyLinkedListNode {
    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode (int nodeData) {
        this.data = nodeData;
        this.next = null;
    }
}

public class SinglyLinkedList {
    public SinglyLinkedListNode head;
    public SinglyLinkedListNode tail;

    public SinglyLinkedList () {
        this.head = null;
        this.tail = null;
    }

    public void InsertNode (int nodeData) {
        SinglyLinkedListNode node = new SinglyLinkedListNode (nodeData);

        if (this.head == null) {
            this.head = node;
        } else {
            this.tail.next = node;
        }

        this.tail = node;
    }

    public static SinglyLinkedListNode InsertNodeAtEnd (SinglyLinkedListNode head, int nodeData) {
        if (head.next == null) {
            head.next = new SinglyLinkedListNode (nodeData);
        } else {
            var curr = head;
            while (head.next != null) {
                head = head.next;
            }
            head.next = new SinglyLinkedListNode (nodeData);
            head = curr;
        }

        return head;
    }

    public static SinglyLinkedListNode InsertNodeAtBeginning (int[] data) {
        SinglyLinkedListNode head = new SinglyLinkedListNode (data[0]);
        head.next = null;
        var prev = head;
        for (int i = 1; i < data.Length; i++) {
            SinglyLinkedListNode node = new SinglyLinkedListNode (data[i]);
            node.next = prev;
            prev = node;
        }
        return prev;
    }

    public static SinglyLinkedListNode LinkedList_Test (int[] data) {
        SinglyLinkedListNode head = null;
        SinglyLinkedListNode tail = null;

        for (int i = 0; i < data.Length; i++) {
            if (head == null) {
                head = new SinglyLinkedListNode (data[i]);
                tail = head;
            } else {
                SinglyLinkedListNode node = new SinglyLinkedListNode (data[i]);
                tail.next = node;
                tail = node;

            }
        }
        return head;
    }

    public static void FloydCycleDetection(SinglyLinkedListNode head){
        
    }
}