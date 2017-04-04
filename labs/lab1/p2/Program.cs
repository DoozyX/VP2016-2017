using System;

namespace p2 {
    internal class Program {
        private static void calculation(int[] arr, out int min, out int max, out double avg) {
            min = arr[0];
            max = arr[0];
            avg = arr[0];
            foreach (var num in arr) {
                if (num < min) min = num;
                if (num > max) max = num;
                avg += num;
            }
            avg = avg / arr.Length;
        }

        private static void Main(string[] args) {
            int n;
            Console.WriteLine("Enter how many numbers to enter: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Enter 1 for automatic generation or 2 for manual");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            int min = Int32.MaxValue, max = Int32.MinValue;
            double total = 0;
            var arr = new int[n];
            if (choice == 1) {
                var random = new Random();
                for (var i = 0; i < n; ++i) {
                    var num = random.Next(1, 1001);
                    arr[i] = num;
                    /*
                    if (num < min) {
                        min = num;
                    }
                    if (num > max) {
                        max = num;
                    }
                    total += num;
                    */
                }
            } else if (choice == 2) {
                for (var i = 0; i < n; ++i) {
                    int num;
                    Console.WriteLine("Enter the {0}th number: ", i + 1);
                    int.TryParse(Console.ReadLine(), out num);
                    arr[i] = num;
                    /*
                    if (num < min) min = num;

                    if (num > max) max = num;
                    total += num;
                    */
                }
            }
            calculation(arr, out min, out max, out total);
            Console.WriteLine("Miniumum is {0}", min);
            Console.WriteLine("Maximum is {0}", max);
            Console.WriteLine("Average is {0}", total);
        }
    }
}