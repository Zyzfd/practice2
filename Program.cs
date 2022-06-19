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
                                First fr = new First();
                                switch (menuInt1)
                                {
                                    case 1: {fr.findRepeat();} break;
                                    case 2: {fr.findEqDigits();} break;
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
                                Second sc = new Second();
                                switch (menuInt1)
                                {
                                    case 1: {sc.findTwoMaxNums();} break;
                                    case 2: {sc.replaceEdges();} break;
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

        
            
        

        
    }
}
