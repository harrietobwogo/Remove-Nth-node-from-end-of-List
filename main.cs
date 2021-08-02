using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //get length of the list
        int len = length(head);
        
        if(len<n){
            throw new Exception("cannot remove node from List");
        }
        if(len==n){
            return head.next;
        }
        //traverse the list until the nth node
        //find the nth node's next
        //find the nth node's previous
        //link previous to nth node's next;
        int N=len-n;
        ListNode prev=null;
        ListNode curr=head;
        for(int i=0; i<N; i++){
            prev=curr;
            curr=curr.next;
        }
        prev.next=curr.next;
         return head;
    }
     public static int length(ListNode head){
         
         int len=0;
         if(head==null){
             return len;
         }
         var temp=head;
         while(temp!=null){
             len ++;
             temp=temp.next;
         }
         return len;
     }
}