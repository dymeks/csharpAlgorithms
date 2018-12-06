using System;
using System.Collections.Generic;
using System.Collections;

namespace algorithms { 
    class MyLinkedList<T>{
        public MyNode<T> head { get; set; }
        public MyLinkedList(){
            this.head = null;
        }

        public void Add(T value){
            MyNode<T> newNode = new MyNode<T>(value);

            newNode.next = this.head;
            this.head = newNode;
        }

        public int Size(){
            MyNode<T> current = this.head;
            int count = 0;

            while(current != null){
                count++;
                current = current.next;
            }

            return count;
        }

        public MyNode<T> getFirst(){
            return this.head;
        }

        public MyNode<T> getLast (){
            MyNode<T> current = this.head;
            
            while(current.next != null){
                current = current.next;
            }

            return current;
        }

        public void Clear(){
            this.head = null;
        }

         public void RemoveFirst(){
            this.head = this.head.next;
        }

        public void RemoveLast (){
            MyNode<T> current = this.head;
            MyNode<T> temp = this.head;
            if(this.head != null){
                if(this.head.next == null){
                    this.head = null;
                } else {
                    while(current.next.next != null){
                        current = current.next;
                    }

                    temp = current;
                    current.next = null;
                }

                
            }
            

            
        }

    }
}