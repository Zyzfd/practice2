using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second {
    class Third {
        int[] mass;
        public Third() {
            Mass ms = new Mass();
            mass = ms.massive();
        }

        public void diffMinMax() {
            int differ = mass.Max() - mass.Min();
            int[] res = new int[mass.Length*2];
            int count = 0;
            for (int i = 0; i < mass.Length; i++) {
                res[count] = mass[i];
                count++;
                if (mass[i] < 0 & mass[i] % 2 == 0) {
                    res[count] = differ;
                    count++;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < res.Length; i++) {
                Console.Write(res[i] + " ");
            }

            Console.ReadLine();
        }
    }
}