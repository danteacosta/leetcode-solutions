public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode aux = new ListNode();
        ListNode current = aux;
        while(list1!=null && list2!=null){
            if(list1.val<list2.val){
                current.next=list1;
                list1=list1.next;
            }
            else{
                current.next=list2;
                list2=list2.next;
            }
            current=current.next;

        }
        //casos de lista acabar primeiro que a outra
        if(list1!=null){
            current.next=list1;
        }
        else{
            current.next=list2;
        }
        //aux ao inves de current pelo edge case das duas listas vazias não retornarem null
        return aux.next;




        
    }
}