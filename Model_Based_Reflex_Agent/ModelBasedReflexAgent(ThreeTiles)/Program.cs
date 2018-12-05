using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBasedReflexAgent_ThreeTiles_
{
    class Program
    {
        public string statusA;
        public string statusB;
        public string statusC;

        public string Position;

        public string v1 = "A";
        public string v2 = "B";
        public string v3 = "C";

        public string Pre_Location = null;
        public string Curr_Location = null;

        public int Suck = 0;

        public void positionA()
        {
            for (int i = 0; i < 3;)
            {
                if (i == 0 && statusA.Equals("dirty"))
                {
                    Pre_Location = null;
                    Curr_Location = v1;
                    statusA = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 0 && statusA.Equals("clean"))
                {
                    Pre_Location = null;
                    Curr_Location = v1;
                    statusA = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 1 && statusB.Equals("dirty"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v2;
                    statusB = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 1 && statusB.Equals("clean"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v2;
                    statusB = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 2 && statusC.Equals("dirty"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v3;
                    statusC = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 2 && statusC.Equals("clean"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v3;
                    statusC = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
            }

            Console.WriteLine("\n\nTiles Status:\n");
            Console.WriteLine("Status of tiles A: " + statusA);
            Console.WriteLine("Status of tiles B: " + statusB);
            Console.WriteLine("Status of tiles C: " + statusC);
            Console.ReadKey();
        }

        public void positionB()
        {
            for (int i = 1; i < 3;)
            {
                if (i == 1 && statusB.Equals("dirty"))
                {
                    Pre_Location = null;
                    Curr_Location = v2;
                    statusB = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 1 && statusB.Equals("clean"))
                {
                    Pre_Location = null;
                    Curr_Location = v2;
                    statusB = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 2 && statusC.Equals("dirty"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v3;
                    statusC = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
                else if (i == 2 && statusC.Equals("clean"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v3;
                    statusC = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i++;
                }
            }
            for (int i = 2; i > 0;)
            {
                if (i == 2 && statusB.Equals("clean"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v2;
                    statusB = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 2 && statusB.Equals("dirty"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v2;
                    statusB = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 1 && statusA.Equals("dirty"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v1;
                    statusA = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 1 && statusA.Equals("clean"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v1;
                    statusA = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
            }

            Console.WriteLine("\n\nTiles Status:\n");
            Console.WriteLine("Status of tiles A: " + statusA);
            Console.WriteLine("Status of tiles B: " + statusB);
            Console.WriteLine("Status of tiles C: " + statusC);
            Console.ReadKey();
        }
        public void positionC()
        {
            for (int i = 3; i > 0;)
            {
                if (i == 3 && statusC.Equals("dirty"))
                {
                    Pre_Location = null;
                    Curr_Location = v3;
                    statusC = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 3 && statusC.Equals("clean"))
                {
                    Pre_Location = null;
                    Curr_Location = v3;
                    statusC = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 2 && statusB.Equals("dirty"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v2;
                    statusB = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 2 && statusB.Equals("clean"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v2;
                    statusB = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 1 && statusA.Equals("dirty"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v1;
                    statusA = "clean";
                    Suck += 1;
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
                else if (i == 1 && statusA.Equals("clean"))
                {
                    Pre_Location = Curr_Location;
                    Curr_Location = v1;
                    statusA = "clean";
                    Console.WriteLine(Curr_Location + " clean and " + " previous location " + Pre_Location + " performance " + Suck);
                    i--;
                }
            }

            Console.WriteLine("\n\nTiles Status:\n");
            Console.WriteLine("Status of tiles A: " + statusA);
            Console.WriteLine("Status of tiles B: " + statusB);
            Console.WriteLine("Status of tiles C: " + statusC);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine("Enter vacuum status A (dirty or clean): ");
            prog.statusA = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter vacuum status B (dirty or clean): ");
            prog.statusB = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter vacuum status C (dirty or clean): ");
            prog.statusC = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter vacuum position (A/B/C): ");
            prog.Position = Console.ReadLine();

            Console.WriteLine("\n\n");

            if (prog.Position.Equals(prog.v1))
            {
                prog.positionA();
            }
            else if (prog.Position.Equals(prog.v2))
            {
                prog.positionB();
            }
            else if (prog.Position.Equals(prog.v3))
            {
                prog.positionC();
            }
        }
    }
}
