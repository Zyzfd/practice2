using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Clear();
                Console.WriteLine("Выберете задание: ");
                Console.WriteLine("1 - 1 блок");
                Console.WriteLine("2 - 2 блок");
                Console.WriteLine("3 - 3 блок");
                Console.WriteLine("4 - 4 блок");
                Console.WriteLine("0 - Выход");
                Console.Write(">> ");
                try {
                    int menuInt = Convert.ToInt32(Console.ReadLine());

                    switch (menuInt) {
                        case 1: {
                                Console.WriteLine("Выберете задание: ");
                                Console.WriteLine("1 - 7 задание");
                                Console.WriteLine("2 - 1 задание");
                                Console.WriteLine("0 - Выход");
                                Console.Write(">> ");
                                int menuInt1 = Convert.ToInt32(Console.ReadLine());
                                switch (menuInt1)
                                {
                                    case 1: {findRepeat();} break;
                                    case 2: {findEqDigits();} break;
                                    case 0: {Environment.Exit(0);} break;
                                    default: throw new Exception();
                                }
                        } break;
                        case 2: {
                                Console.WriteLine("Выберете задание: ");
                                Console.WriteLine("1 - 7 задание");
                                Console.WriteLine("2 - 1 задание");
                                Console.WriteLine("0 - Выход");
                                Console.Write(">> ");
                                int menuInt1 = Convert.ToInt32(Console.ReadLine());
                                switch (menuInt1)
                                {
                                    case 1: {findTwoMaxNums();} break;
                                    case 2: {replaceEdges();} break;
                                    case 0: {Environment.Exit(0);} break;
                                    default: throw new Exception();
                                }
                        } break;
                        case 3: {
                            Console.WriteLine("Выберете задание: ");
                            Console.WriteLine("1 - 7 задание");
                            Console.WriteLine("2 - 1 задание");
                            Console.WriteLine("0 - Выход");
                            Console.Write(">> ");
                            int menuInt1 = Convert.ToInt32(Console.ReadLine());
                            switch (menuInt1)
                            {
                                case 1: {} break;
                                case 2: {} break;
                                case 0: {Environment.Exit(0);} break;
                                default: throw new Exception();
                            }
                        } break;
                        case 4: {
                            Console.WriteLine("Выберете задание: ");
                            Console.WriteLine("1 - 7 задание");
                            Console.WriteLine("2 - 1 задание");
                            Console.WriteLine("0 - Выход");
                            Console.Write(">> ");
                            int menuInt1 = Convert.ToInt32(Console.ReadLine());
                            switch (menuInt1)
                            {
                                case 1: {} break;
                                case 2: {} break;
                                case 0: {Environment.Exit(0);} break;
                                default: throw new Exception();
                            }
                        } break;

                        case 0: {Environment.Exit(0);} break;
                        default: throw new Exception();
                    }
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void findRepeat() {
            bool exit = false;
            while (!exit) {
                try {
                Random rand = new Random();
                Console.Write("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] mass = new int[size];
                for (int i = 0; i < mass.Length; i++) {
                    mass[i] = rand.Next(1, 1000);
                    Console.Write(mass[i] + " ");
                    //Console.Write("Введите число: ");
                    //mass[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < mass.Length-1; i++) {
                    if ((mass[i]%2 == 0 & mass[i+1]%2 != 0) || (mass[i]%2 != 0 & mass[i+1]%2 == 0)) {
                        continue;
                    } else {
                        Console.WriteLine();
                        Console.WriteLine(i+2);
                        exit = true;
                        break;
                    }
                }
                if (exit == false) {
                    Console.WriteLine("0");
                }
                exit = true;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
            
        static void findEqDigits() {
            bool exit = false;
            while (!exit) {
                try {
                    Random rand = new Random();
                    Console.Write("Введите размер массива: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] mass = new int[size];
                    int[] results = new int[size];
                    for (int i = 0; i < mass.Length; i++) {
                        mass[i] = rand.Next(1, 1000);
                        Console.Write(mass[i] + " ");
                        //Console.Write("Введите число: ");
                        //mass[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    
                    int count = 0;
                    for (int i = 0; i < mass.Length; i++) {
                        bool result = true;
                        char[] digits = mass[i].ToString().ToCharArray();
                        for (int j = 0; j < digits.Length-1; j++) {
                            if (digits[j] != digits[j + 1]) {
                                result = false;
                            }
                        }
                        if (result) {
                            results[count] = mass[i];
                            count += 1;
                        }
                    }
                    Console.WriteLine();
                    for (int i = 0; i < results.Length; i++) {
                        Console.Write(results[i] + " ");
                    }
                    exit = true;
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }

        static void findTwoMaxNums() {
            bool exit = false;
            while (!exit) {
                try {
                    Random rand = new Random();
                    Console.Write("Введите размер массива: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] mass = new int[size];
                    for (int i = 0; i < mass.Length; i++) {
                        mass[i] = rand.Next(1, 1000);
                        Console.Write(mass[i] + " ");
                        //Console.Write("Введите число: ");
                        //mass[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int max = Int32.MinValue;
                    for (int i = 0; i < mass.Length; i++) {
                        if (max < mass[i]) max = mass[i];
                    }

                    int nearMax = Int32.MaxValue;
                    int x1 = 0, x2 = 0;
                    for (int i = 0; i < mass.Length; i++) {
                        for (int j = 0; j < mass.Length; j++) {
                            if (i == j) continue;
                            if (Math.Abs(mass[i] + mass[j]) < nearMax) {
                                x1 = i;
                                x2 = j;
                                nearMax = Math.Abs(mass[i] + mass[j]);
                            }
                        }
                    }
                    int temp = mass[x1];
                    mass[x1] = mass[x2];
                    mass[x2] = temp;

                    Console.WriteLine();
                    for (int i = 0; i < mass.Length; i++) {
                        Console.Write(mass[i] + " ");
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }

        static void replaceEdges() {
            bool exit = false;
            while (!exit) {
                try {
                    Random rand = new Random();
                    Console.Write("Введите размер массива: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] mass = new int[size];
                    for (int i = 0; i < mass.Length; i++) {
                        mass[i] = rand.Next(1, 1000);
                        Console.Write(mass[i] + " ");
                        //Console.Write("Введите число: ");
                        //mass[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                    Console.Write("Введите индекс конца первого отрезка: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int lastCounter = 1;
                    for (int i = 0; i < mass.Length; i++) {
                        if (i <= n) {
                            int temp = mass[n + lastCounter];
                            mass[n + lastCounter] = mass[i];
                            mass[i] = temp;
                            lastCounter += 1;
                        }
                    }

                    Console.WriteLine();
                    for (int i = 0; i < mass.Length; i++) {
                        Console.Write(mass[i] + " ");
                    }
                    exit = true;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
