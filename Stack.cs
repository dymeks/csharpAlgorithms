using System;
using System.Collections.Generic;
using System.Collections;

namespace algorithms {
    class Stack1 {
        public ArrayList data { get; set; }
        public Stack1(){
            this.data = new ArrayList();
        }

        public void add(object o){
            this.data.Add(o);
        }

        public object remove(){
            var temp = this.data[this.data.Count -1];
            this.data.RemoveAt(this.data.Count - 1);
            return temp;
        }

        public object peek(){
            return this.data[this.data.Count -1];
        }
    }
}