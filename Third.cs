using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second {
    class Third {
        int[] mass;
        public Third() {
            mass = Mass.massive(mass);
        }

        public void diffMinMax() {
            int differ = mass.Max() - mass.Min();
            for (int i = 0; i < mass.Length; i++) {
                if (mass[i] < 0 & mass[i] % 2 == 0) {
                    Array.Resize(ref mass, mass.Length+1);
                    for (int j = mass.Length-2; j > 0; j--) {
                    if (j > i) {
                        mass[j+1] = mass[j];
                    }
                    }
                    mass[i+1] = differ;
                    i++;
                }
            }

            Mass.printMass(mass);
            Console.ReadLine();
        }

        public void addToSeries() {
            for (int i = 0; i < mass.Length; i++) {
                if (mass[i] != mass[i+1]) {
                    Array.Resize(ref mass, mass.Length+1);
                    for (int j = mass.Length-2; j > 0; j--) {
                        if (j > i) {
                            mass[j+1] = mass[j];
                        }
                    }
                    mass[i+1] = mass[i];
                    i++;
                }
            }

            Mass.printMass(mass);
            Console.ReadLine();
        }
    }
}