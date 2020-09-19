//Mars Rover Squad by Kaan KAZAZ

using MRSquad.Library;
using System;

namespace MRSquad.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPlanetSurface mars = new MarsSurface("5 5");
                //Console.WriteLine($"X coord:{mars._width}, Y coord:{mars._height}");

                //IVehicle rover1 = new MarsRover("1 2 N", "LMLMLMLMM", mars);
                //Console.WriteLine(rover1.PrintFinalPositionAndHeading());

                //IVehicle rover2 = new MarsRover("3 3 E", "MMRMMRMRRM", mars);
                //Console.WriteLine(rover2.PrintFinalPositionAndHeading());

                Squad mrSquad = new Squad(mars);

                mrSquad.AddVehicle("1 2 N", "LMLMLMLMM");
                mrSquad.AddVehicle("3 3 E", "MMRMMRMRRM");

                foreach (var marsRover in mrSquad)
                {
                    Console.WriteLine(marsRover.PrintFinalPositionAndHeading());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message.ToString()}");
            }
        }
    }
}
