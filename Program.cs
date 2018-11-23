using System;
using System.Collections;
namespace algorithms
{
    class Program
    {
        public static void Print1To255(){
            for(int i  = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
        }

        public static void PrintIntSum(){
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                Console.Write(i);
                sum += i;
                Console.WriteLine(" "+ sum + " ");
            }
        }

        public static void PrintMax(int[] arr){
            int max = arr[0];

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] > max){
                    max = arr[i];
                }
            }

            Console.Write(max);
        }

        public static ArrayList OddArray(){
            ArrayList result = new ArrayList();
            for(int i = 1; i<= 255; i++){
                if(i % 2 == 1){
                    result.Add(i);
                }
            }
            Console.WriteLine(result.ToString());
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Print1To255();
            // PrintIntSum ();
            // int[] test = new int[] {1,4,-9,5,4};
            // PrintMax(test);
            OddArray();
        }
    }
}
