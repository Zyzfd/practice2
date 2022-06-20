using System;

namespace second {
    class Fourth {
        int[] mass;
        public Fourth() {
            Mass ms = new Mass();
            mass = ms.massive();
        }


        int[] rmAndResize(int[] mass, int ind) {
            for (int i = ind; i < mass.Length-1; i++) {
                mass[i] = mass[i+1];
            }
            Array.Resize(ref mass, mass.Length-1);
            return mass;
        }

        public void delKrat() {
            int differ = Math.Abs(mass[0]) - Math.Abs(mass[mass.Length-1]);
            for (int i = 0; i < mass.Length; i++) {
                if (mass[i] % differ == 0) {
                    mass = rmAndResize(mass, i);
                }
            }

            Mass.printMass(mass);
            Console.ReadLine();
        }

        public void delTwiceTriple() {
            int[] counter = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++) {
                int res = 0;
                for (int j = 0; j < mass.Length; j++) {
                    if (mass[j] == mass[i]) {
                        res++;
                    }
                }
                counter[i] = res;
            }

            for (int i = 0; i < mass.Length; i++) {
                if (counter[i] == 2 | counter[i] == 3) {
                    mass = rmAndResize(mass, i);
                    counter = rmAndResize(counter, i);
                    i--;
                }
            }

            Mass.printMass(mass);
            Console.ReadLine();
        }
    }
}