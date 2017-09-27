using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {
                // declare variables
                int input;
                Console.WriteLine("Learn Your squares and cubes!");
                Console.WriteLine("Enter an integer");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");

                //process

                for (int i = 1; i <= input; i++)
                {
                    Console.WriteLine(i + "\t" + (i + i) + "\t" +(i + i + i));
                }


                string UserChoice;
                Console.WriteLine("Do you want to run the code again? (N/No/y/yes)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No")
                {
                    ProgramContinue = false;
                }
            }



        }
    }
}


