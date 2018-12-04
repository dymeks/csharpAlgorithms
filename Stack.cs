using System;
using System.Collections.Generic;
using System.Collections;

namespace algorithms {
    class GenericStack1<T> {
        public List<T> data { get; set; }
        public GenericStack1(){
            this.data = new List<T>();
        }

        public void add(T input){
            this.data.Add(input);
        }

        public T remove(){
            var temp = this.data[this.data.Count -1];
            this.data.RemoveAt(this.data.Count - 1);
            return temp;
        }

        public T peek(){
            return this.data[this.data.Count -1];
        }
    }
}