using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second {
    class First {
        int[] mass;
        public First() {
            Mass ms = new Mass();
            mass = ms.massive();
        }

        public void findRepeat() {
            bool exit = false;
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
            Console.ReadLine();
        }

        public void findEqDigits() {
            int[] results = new int[mass.Length];
            
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
            
            Mass.printMass(mass);
            Console.ReadLine();
        }
    }
}