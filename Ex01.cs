using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("BẤM PHÍM 1 ĐỂ XEM BÀI 1\nBẤM PHÍM 2 ĐỂ XEM BÀI 2");
            int choice = 0;
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: ex01();
                    break;
                case 2:
                    Console.WriteLine("BẤM TỪ 1 - 4 ĐỂ LỰA CHỌN CÁC HÀM\n 1. Tìm giá trị lớn nhất\n 2. Sắp xếp\n 3. In số nguyên tố\n 4. Tìm vị trí giá trị");
                    int choice1 = 0;
                    choice1 = int.Parse(Console.ReadLine());
                    
                    int[][] newarr = new int[4][];
                    newarr[0]= new int[4];
                    newarr[1]= new int[5];
                    newarr[2]= new int[3];
                    newarr[3]= new int[2];
                    
                    RandomArr(newarr);
                    PrintArr(newarr);

                    switch (choice1)
                    {
                        case 1:
                            Console.Write("Số lớn nhất trong mảng là: "); PrintLargestRowArr(newarr);
                            break;
                        case 2:
                            Console.WriteLine("Số nguyên tố trong mảng là: "); PrintPrimeInArr(newarr);
                            break;
                        case 3:
                            Console.WriteLine("Mảng sau khi sắp xếp"); SortArr(newarr);
                            PrintArr(newarr);
                            break;
                        case 4:
                            Console.WriteLine("Nhập phần tử muốn tìm kiếm");
                            int choice2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Vị trí của phần tử {choice2} ");SearchNums(newarr,choice2);
                            break;

                    }



                    
                    break;
            }
            Console.ReadLine();
            
        }
        static void ex01()
        {
            int[][] jagarr = new int[4][];
            jagarr[0] = new int[5] { 1, 1, 1, 1, 1, };
            jagarr[1] = new int[2] { 2, 2 };
            jagarr[2] = new int[4] { 3, 3, 3, 3 };
            jagarr[3] = new int[2] { 4, 4};
            for (int i = 0; i < jagarr.Length; i++)
            {
                for(int j = 0; j < jagarr[i].Length; j++)
                {
                    Console.Write(jagarr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void RandomArr(int[][] a)
        {
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = rd.Next(1, 101);
                }
            }
        }
        static void PrintArr(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void PrintLargestRowArr(int[][] a)
        {
            int maxarr = a[0][0];
            for (int i = 0; i < a.Length; i++)
            {
                int maxrows = a[i][0];
                for (int j = 1; j < a[i].Length; j++)
                {
                    if (maxrows < a[i][j])
                    {
                        maxrows = a[i][j];
                    }                                     
                }
                Console.WriteLine($"Max of row {i} = {maxrows}");
                if (maxrows > maxarr)
                    maxarr = maxrows;
            }
            Console.WriteLine($"Max of Array = {maxarr}");
        }
        static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }             
            }
            return true;
            
        }
        static void PrintPrimeInArr (int[][] a)
        {
            for (int i = 0; i< a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (isPrime(a[i][j]))
                        Console.WriteLine($"{a[i][j]}");
                }
            }
        }
        static void SortArr (int[][] a)
        {
            for (int i = 0;i< a.Length; i++)
            {
                for (int j = 0;j < a[i].Length; j++)
                {
                    Array.Sort(a[i]);
                }
            }
        }
        static void SearchNums(int[][]a, int num)
        {
            for (int i = 0; i< a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == num)
                        Console.WriteLine($"row {i} and column {j}");
                }
            }
        }


    }
}

