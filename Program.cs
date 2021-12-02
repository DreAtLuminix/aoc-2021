using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDay1(1);
            RunDay1(2);
            RunDay1(3);
            RunDay1(10);
        }

        static void RunDay1(int numOfLevelsForSlidingWindow)
        {
            var measurementList = InputData.GetMeasurementData(numOfLevelsForSlidingWindow);
            int previousMeasurement = int.MinValue;
            int numOfIncreases = 0;
            foreach (var currentMeasurement in measurementList)
            {
                if (previousMeasurement != int.MinValue)
                {
                    if (currentMeasurement > previousMeasurement)
                    {
                        numOfIncreases++;
                    }
                }
                previousMeasurement = currentMeasurement;
            }
            Console.WriteLine($"Day 1, levels {numOfLevelsForSlidingWindow}. El Answer es = {numOfIncreases}");
        }
    }

}
