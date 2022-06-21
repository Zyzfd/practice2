using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second {
    class Second {
        int[] mass;
        public Second() {
            mass = Mass.massive(mass);
        }

        public void findTwoMaxNums() {
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

            Mass.printMass(mass);
            Console.ReadLine();
        }

        public void replaceEdges() {
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

            Mass.printMass(mass);
            Console.ReadLine();
        }
    }
}