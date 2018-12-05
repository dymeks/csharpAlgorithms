using System;
using System.Collections.Generic;
using System.Collections;

namespace algorithms {
    class MyNode<T> {
        public T data { get; set; }
        public MyNode<T> next { get; set; }
        public MyNode(T value){
            this.data = value;
            this.next = null;
        }
    }
}