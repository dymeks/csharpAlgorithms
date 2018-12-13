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

        public MyNode<T> RemoveLast (){
            MyNode<T> current = this.head;
            MyNode<T> temp = this.head;
            if(this.head != null){
                if(this.head.next == null){
                    this.head = null;
                } else {
                    while(current.next.next != null){
                        current = current.next;
                    }

                    temp = current.next;
                    current.next = null;
                }

                
            }
            
            return temp;  
        }

        public void InsertLast (T data){
            MyNode<T> current = this.head;
            MyNode<T> newData = new MyNode<T>(data);

            if(this.head != null){
                if(this.head.next == null){
                    this.head.next = newData;
                } else {
                    while(current.next.next != null){
                        current = current.next;
                    }

                    current.next = newData;
                }

                
            } 
        }

        public MyNode<T> GetAt(int index){
            int count = 1;
            MyNode<T> current = this.head;

            while(count < index && current != null){
                current = current.next;
                count++;
            }

            return current;

        }

        public void RemoveAt(int index){
            
            if(this.head != null){
                MyNode<T> beforeRemove = this.GetAt(index -1);
                if(index == 0){
                    RemoveFirst();
                } else if(beforeRemove != null && beforeRemove.next != null){
                    beforeRemove.next = beforeRemove.next.next;
                } 
                
            }
            
        }

        public override string ToString(){
            MyNode<T> current = this.head;
            string result = ""; 
            while(current != null){
                result += current.data + ", ";
                current = current.next;
            }

            return result;
        }

    }


}