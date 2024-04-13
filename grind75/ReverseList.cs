/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null;
        ListNode current = head;
        while(current!=null){
            ListNode temp = current.next; //salva o proximo
            current.next = previous; //inverte o ponteiro
            previous = current; //atualiza o previous uma posição afrente
            current = temp; //atualiza o current uma posição afrente
        }
        return previous;
    }
}