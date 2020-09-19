using System;
using System.Collections.Generic;
using System.Text;

namespace MRSquad.ConsoleApp
{
    public interface IVehicle
    {
        public int _x { get; set; }
        public int _y { get; set; }
        public char _direction { get; set; }
        public string PrintFinalPositionAndHeading();
    }
}
