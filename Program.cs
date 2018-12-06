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

        public static void PrintPyramids(int n){
            int midpoint = (2*n -1)/2;
            
            for(int row = 0; row < n; row++){
                string level = "";
                for(int col = 0; col < 2*n -1; col++){
                    if(midpoint - row <= col && midpoint + row >= col){
                        level += "#";
                    } else {
                        level += " ";
                    }
                }
                System.Console.WriteLine(level);
            }
        }

        

        public static int ReverseNumber(int n){
            string num = "" + Math.Abs(n);
            string reversed = "";
            
            for(int i = (num.Length -1); i >= 0; i--){
                reversed += num[i].ToString();
            }

            if(n < 0){
                reversed = "-" + reversed;
            }
           
            return Int32.Parse(reversed);
        }

        public static void FizzBuzz(int n){
            if(n % 3 == 0 && n % 5 == 0){
                System.Console.WriteLine("fizzbuzz");
            } else if ( n % 3 == 0){
                System.Console.WriteLine("fizz");
            } else if( n % 5 == 0){
                System.Console.WriteLine("buzz");
            } else {
                System.Console.WriteLine(n);
            }
        }

        //Iterative solution to Fibonacci sequence.
        //Time complexity O(n)
        public static int iFib(int n){
            if(n == 0 || n == 1){
                return n;
            }

            int first = 0;
            int second = 1;

            for(int i = 2; i <= n; i++){
                int temp = first;
                first = second;
                second = temp + first;
            }

            return second;
        }

        //Recursive Solution to Fibonacci sequence.
        //Returns the number in the Fibonacci sequence.
        //Time Complexity O(2^n). Exponential time.
        public static int rFib(int n){
            if(n < 2){
                return n;
            }

            return rFib(n-1) + rFib(n-2);
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
            // PrintSteps(5);
            // PrintPyramids(10);
            // FizzBuzz(15);
            // System.Console.WriteLine(iFib(9));
            // System.Console.WriteLine(rFib(9));
            // System.Console.WriteLine(ReverseNumber(-12300));
            // GenericStack1<string> s = new GenericStack1<string>();
            // s.add("hi");
            // s.add("hello");
            // GenericStack1<int> s2 = new GenericStack1<int>();
            // s2.add(23);
            // string temp = s.remove();
            // System.Console.WriteLine(temp);
            // System.Console.WriteLine(s.peek());
            // System.Console.WriteLine(s2.peek());

            MyNode<string> n = new MyNode<string>("hello");
            System.Console.WriteLine(n.data);
            MyLinkedList<string> s = new MyLinkedList<string>();
            s.Add("Hi there");
            s.Add("george");
            System.Console.WriteLine(s.head.data);
            System.Console.WriteLine(s.head.next.data);
            s.RemoveLast();
            System.Console.WriteLine(s.Size());
            

        }
    }
}
