using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

        static void Main(string[] args)
        {
            // Khởi tạo danh sách các số
            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            int n = numbers.Length;

            // Khởi tạo biến first và last
            int first = numbers[0];
            int last = numbers[n - 1];

            Console.WriteLine("1, 2, 3, 4, 5, 6 ");

            // Tính tổng các số theo yêu cầu
            int sum = 0;
            for (int i = 0; i < n / 2; i++)
            {
                sum += (first + i) + (last - i);
                Console.Write(" " + sum);
                sum = 0;


            }
            if (n % 2 != 0)
            {
                sum += numbers[n / 2];
                Console.Write(" " + sum);
                sum = 0;

            }
            Console.ReadKey();
        }
    }
