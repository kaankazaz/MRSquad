using System;
using System.Collections.Generic;
using System.Text;

namespace MRSquad.ConsoleApp
{
    public class MarsSurface : IPlanetSurface
    {
        public virtual int _height { get; private set; }
        public virtual int _width { get; private set; }

        public MarsSurface(int x, int y)
        {
            this._height = y;
            this._width = x;
        }

        public MarsSurface(string coords)
        {
            ParseSurfaceSize(coords);
        }

        private void ParseSurfaceSize(string coords)
        {
            string[] surfaceXY = coords.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (surfaceXY.Length != 2)
                throw new MRSquadException("Surface size must consist of two coordinates (X and Y)");

            int parsedWidth;
            if (!Int32.TryParse(surfaceXY[0].ToString(), out parsedWidth))
                throw new MRSquadException("Surface width must be an integer");
            _width = parsedWidth;

            int parsedHeight;
            if (!Int32.TryParse(surfaceXY[1].ToString(), out parsedHeight))
                throw new MRSquadException("Surface height must be an integer");
            _height = parsedHeight;


        }
    }
}
