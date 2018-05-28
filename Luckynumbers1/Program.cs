using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckynumbers1CW
{
    class Program
    {
        static void Main(string[] args)

        {
            // declaring integers for the later call for them to be identified

            int iNum1;
            int iNum2;
            int iNum3;
            int iNum4;
            int iNum5;
            int iNum6;

            int iCount;
            int iGuess;

            // declaring constants in this space


            int iBALLS = 6;
            int iMATCHONE = 10;
            int iMATCHTWO = 100;
            int iMATCHTHREE = 1000;
            int iMATCHFOUR = 10000;
            int iMATCHFIVE = 100000;
            int iMATCHSIX = 1000000;


            // declaring arrays in this space

            int[] iSortedNums = new int[6];
            int[] iGuesses = new int[6];
            int[] iSortedGuesses = new int[6];

            // generating random numbers in this space



            Random randomnumber = new Random();

            iNum1 = randomnumber.Next(1, 49);//xcludes endpoint so gives number between 1 and 49
            iNum2 = randomnumber.Next(1, 49);
            iNum3 = randomnumber.Next(1, 49);
            iNum4 = randomnumber.Next(1, 49);
            iNum5 = randomnumber.Next(1, 49);
            iNum6 = randomnumber.Next(1, 49);
            iSortedNums[0] = iNum1;
            iSortedNums[1] = iNum2;
            iSortedNums[2] = iNum3;
            iSortedNums[3] = iNum4;
            iSortedNums[4] = iNum5;
            iSortedNums[5] = iNum6;
            Array.Sort(iSortedNums); // sort random numbers in this space

            for (iCount = 0; iCount < iBALLS; iCount++)
            {
                Console.Write("\nNo:" + (iCount + 1) + (" Welcome to the lottery! please enteranumber between 1 and 49 "));
                iGuess = int.Parse(Console.ReadLine());

                while (iGuess < 1 || iGuess > 49)
                {
                    Console.WriteLine("You have entered an incorrect number please try again");
                    Console.Write("\nNo:" + (iCount + 1) + " Choose your number: ");
                    iGuess = int.Parse(Console.ReadLine());
                }

                iGuesses[iCount] = iGuess;
                iSortedGuesses[iCount] = iGuess;
            }
           
            Array.Sort(iSortedGuesses); // sort the guesses here for printing to the console

            Console.WriteLine();
            Console.WriteLine("The random numbers are    : " + iNum1 + ", " + iNum2 + ", " + iNum3+", " + iNum4 + ", " + iNum5 + ", " + iNum6);
            Console.WriteLine("The numbers you chose are : " + iGuesses[0] + ", " + iGuesses[1] + ", " + iGuesses[2] + "," + iGuesses[4] + ", " + iGuesses[5] + ", " + iGuesses[6]);
            Console.WriteLine();

            if (iGuesses[0] == iNum1 && iGuesses[1] == iNum2 && iGuesses[2] == iNum3)
            {
                Console.WriteLine("you won $" + iMATCHFOUR);
            }

            else if (iSortedGuesses[0] == iSortedNums[0] && iSortedGuesses[1] == iSortedNums[1]
            && iSortedGuesses[2] == iSortedNums[2])
            {
                Console.WriteLine("you won $" + iMATCHTHREE);
            }

            else if ((iGuesses[0] == iNum1 && iGuesses[1] == iNum2) || (iGuesses[1] == iNum2 &&

iGuesses[2] == iNum3))
            {
                Console.WriteLine("you won $" + iMATCHTWO);
            }

            else if (iGuesses[0] == iNum1 || iGuesses[1] == iNum2 || iGuesses[2] == iNum3)
            {
                Console.WriteLine("you won $" + iMATCHONE);
            }

            else
            {
                Console.WriteLine("sorry, you didn't win anything");
            }

            Console.ReadKey();
        }

    }

}

