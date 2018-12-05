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


    }
}