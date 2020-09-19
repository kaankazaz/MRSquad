using System;

namespace MRSquad.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPlanetSurface Mars = new MarsSurface("5 5");
                Console.WriteLine($"X coord:{Mars._width}, Y coord:{Mars._height}");

                IVehicle rover1 = new MarsRover("1 2 N", "LMLMLMLMM", Mars);
                Console.WriteLine(rover1.PrintFinalPositionAndHeading());

                IVehicle rover2 = new MarsRover("3 3 E", "MMRMMRMRRM", Mars);
                Console.WriteLine(rover2.PrintFinalPositionAndHeading());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message.ToString()}");
            }
        }
    }
}
