using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1ChronalCalibrations
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalFrequency = 0;


            string[] frequencyShifts = System.IO.File.ReadAllLines(
                @"C:/e/AdventOfCodeChallenges/Day1ChronalCalibrations/Day1ChronalCalibrations/Data/input.txt");

            for (int i = 0; i < frequencyShifts.Length; i++)
            {
                string frequencyDirection = frequencyShifts[i].Substring(0, 1);
                string frequencyMagnitude = frequencyShifts[i].Substring(1);
                
                if (frequencyDirection == "+")
                {
                    finalFrequency += Convert.ToInt32(frequencyMagnitude);
                }
                else
                {
                    finalFrequency -= Convert.ToInt32(frequencyMagnitude);
                }
            }

            Console.WriteLine($"Final frequency: {finalFrequency}\n\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
