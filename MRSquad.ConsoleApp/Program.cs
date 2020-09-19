using System;

namespace MRSquad.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPlanetSurface Mars = new MarsSurface("5 6 7");
                Console.WriteLine($"X coord:{Mars._width}, Y coord:{Mars._height}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message.ToString()}");
            }
        }
    }
}
