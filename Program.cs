using System;
using System.Collections;
namespace algorithms
{
    class Program
    {
        //Prints numbers from 1 to 255.
        public static void Print1To255(){
            for(int i  = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
        }

        //Prints the cumaltive sum from 0 to 255.
        public static void PrintIntSum(){
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                Console.Write(i);
                sum += i;
                Console.WriteLine(" "+ sum + " ");
            }
        }

        //Takes an integer array.
        //Prints the maximum value in the array.
        public static void PrintMax(int[] arr){
            int max = arr[0];

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] > max){
                    max = arr[i];
                }
            }

            Console.Write(max);
        }

        //Creates a list of odd numbers from 1 to 255.
        //Returns an ArrayList.
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

        //Takes a number and an array of numbers.
        //Prints how many numbers are greater than y.
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

        //Takes an integer array.
        //Prints the Max, Min and the Average value in the 
        //array.
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

        //Takes an array of Integers
        //Swaps all negative numbers in the array with the word "Dojo".
        //Returns an array of Objects with Strings and numbers.
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

        //Prints all odd numbers from 1 to 255.
        public static void Print1To255Odd(){
            for(int i = 1; i<=255; i++){
                if(i %2 == 1){
                    System.Console.WriteLine(i);
                }
            }
        }

        //Takes an integer array.
        //Prints every element in the array.
        public static void PrintArrayVals(int[] arr){
            foreach(int num in arr){
                System.Console.WriteLine(num);
            }
        }

        //Takes an integer array.
        //Prints the average value in the array.
        public static void PrintAverage(int[] arr){
            int sum = 0;

            foreach(int num in arr){
                sum += num;
            }

           System.Console.WriteLine(sum/arr.Length);
        }

        //Takes an integer array.
        //Replaces all the values in the array with their squares.
        //Returns the original array.
        public static int[] SquareValues(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                arr[i] = arr[i]*arr[i];
                
            }
            PrintArray(arr);
            return arr;
        }

        //Takes an integer array.
        //replaces all negative numbers in the array with 0.
        //Returns the original array.
        public static int[] ZeroOutNegatives(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
            }
            PrintArray(arr);
            return arr;
        }

        //Takes an array of Integers.
        //Shifts all the values in the array to the left.
        //Once the shifting is done, the last space becomes 0.
        public static int[] ShiftValuesLeft(int[] arr){
            
            for(int i = 1; i< arr.Length; i++){
                arr[i-1] = arr[i];
            }
            arr[arr.Length -1] = 0;
            PrintArray(arr);
            return arr;
        }

        //Takes an array of Integers.
        //Prints out each number.
        public static void PrintArray(int[] arr){
            foreach(int num in arr){
                System.Console.WriteLine(num);
            }
        }

        //Prints out n steps. 
        //Steps start in the top left corner.
        public static void PrintSteps(int n){
            for(int i = 0; i < n; i++){
                string row = "";
                for(int col = 0; col < n; col++){
                    if(col <= i){
                        row += "#";
                    } else {
                        row += " ";
                    }
                }
                System.Console.WriteLine(row);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Print1To255();
            // PrintIntSum ();
            // int[] test = new int[] {1,4,-9,5,4};
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
            PrintSteps(5);
        }
    }
}
