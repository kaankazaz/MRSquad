using System;
using System.Collections.Generic;
using System.Text;

namespace MRSquad.ConsoleApp
{
    public class Squad : List<IVehicle>
    {
        private IPlanetSurface _surface { get; set; }
        public Squad(IPlanetSurface surface)
        {
            _surface = surface;
        }

        public void AddVehicle(string initialPos, string moveCommands)
        {
            this.Add(new MarsRover(initialPos, moveCommands, _surface));
        }
    }
}
