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

        public static void GreaterThanY(int[] arr, int y) {
            int count = 0;
            foreach(int num in arr){
                if(num > y){
                    count++;
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine(count);
        }

        public static void PrintMaxMinAvg(int[] arr){
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            foreach(int num in arr){
                if(num < min){
                    min = num;
                }

                if(num > max){
                    max = num;
                }
                sum += num;

            }
            double average = sum/arr.Length;
            Console.WriteLine("Max is: " + max);
            System.Console.WriteLine("Min is: " + min);
            System.Console.WriteLine("Average is: " + average);
        }

        public static Object[] SwapStringForNegatives(int[] arr){
            Object[] result = new Object[arr.Length];

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    result[i] = "Dojo";
                } else {
                    result[i] = arr[i];
                }
                Console.WriteLine(result[i]);
            }

            return result;
        }

        public static void Print1To255Odd(){
            for(int i = 1; i<=255; i++){
                if(i %2 == 1){
                    System.Console.WriteLine(i);
                }
            }
        }

        public static void PrintArrayVals(int[] arr){
            foreach(int num in arr){
                System.Console.WriteLine(num);
            }
        }

        public static void PrintAverage(int[] arr){
            int sum = 0;

            foreach(int num in arr){
                sum += num;
            }

           System.Console.WriteLine(sum/arr.Length);
        }

        public static int[] SquareValues(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                arr[i] = arr[i]*arr[i];
                
            }
            PrintArray(arr);
            return arr;
        }

        public static int[] ZeroOutNegatives(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
            }
            PrintArray(arr);
            return arr;
        }

        public static int[] ShiftValuesLeft(int[] arr){
            
            for(int i = 1; i< arr.Length; i++){
                arr[i-1] = arr[i];
            }
            arr[arr.Length -1] = 0;
            PrintArray(arr);
            return arr;
        }

        public static void PrintArray(int[] arr){
            foreach(int num in arr){
                System.Console.WriteLine(num);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Print1To255();
            // PrintIntSum ();
            int[] test = new int[] {1,4,-9,5,4};
            // PrintMax(test);
            // OddArray();
            // GreaterThanY(test,2);
            // PrintMaxMinAvg(test);
            // SwapStringForNegatives(test);
            // Print1To255Odd();
            // PrintArrayVals(test);
            // PrintAverage(test);
            // SquareValues(test);
            // ZeroOutNegatives(test);
            // ShiftValuesLeft(test);
        }
    }
}
