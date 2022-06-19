using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second {
    class Mass {
        int[] mass;
        public int[] massive() {
            bool exit = false;
            while (!exit) {
                try {
                    Random rand = new Random();
                    Console.Write("Введите размер массива: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    mass = new int[size];
                    Console.Write("Рандом (0, 1)? ");
                    int randAsk = Convert.ToInt32(Console.ReadLine());

                    if (randAsk == 1) {
                        for (int i = 0; i < mass.Length; i++) {
                        mass[i] = rand.Next(1, 1000);
                        Console.Write(mass[i] + " ");
                        }
                    } else {
                        for (int i = 0; i < mass.Length; i++) {
                        Console.Write("Введите число: ");
                        mass[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    exit = true;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            return mass;
        }
    }
}