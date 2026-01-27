namespace LearningAlgorithms.Algoritmos.Advanced {
    /*
        A linked list is said to contain a cycle if any node is visited more than once while traversing the list. 
        Given a pointer to the head of a linked list, determine if it contains a cycle. 
        If it does, return 1. Otherwise, return 0.
     */
    public static class ListaSimple {
        //var list2 = new SinglyLinkedList();
        //list2.Insert(1);
        //list2.Insert(2);
        //list2.Insert(3);
        //list2.Insert(4);

        public static bool hasCycle(SinglyLinkedListNode head) {
            if(head == null)
                return false;

            SinglyLinkedListNode slow = head;
            SinglyLinkedListNode fast = head;

            while(fast != null && fast.next != null) {
                slow = slow.next;           // avanza 1
                fast = fast.next.next;      // avanza 2

                if(slow == fast)
                    return true;            // se encontraron → hay ciclo
            }

            return false;                   // fast llegó a null → no hay ciclo
        }
    }

    public class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int value) {
            data = value;
            next = null;
        }
    }

    public class SinglyLinkedList {
        public SinglyLinkedListNode head;

        public SinglyLinkedList() {
            head = null;
        }

        public void Insert(int value) {
            var newNode = new SinglyLinkedListNode(value);

            if(head == null) {
                head = newNode;
                return;
            }

            var current = head;
            while(current.next != null) {
                current = current.next;
            }

            current.next = newNode;
        }
    }
}
