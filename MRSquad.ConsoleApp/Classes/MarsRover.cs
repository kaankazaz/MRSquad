using System;
using System.Collections.Generic;
using System.Text;

namespace MRSquad.ConsoleApp
{
    public class MarsRover : IVehicle
    {
        public int _x { get; set; }
        public int _y { get; set; }
        public char _direction { get; set; }

        public enum Directions
        {
            North = 'N',
            South = 'S',
            East = 'E',
            West = 'W'
        }

        public enum MoveCommands
        {
            Move = 'M',
            Left = 'L',
            Right = 'R'
        }


        public MarsRover(string initialPos, string moveCommands, IPlanetSurface planet)
        {
            initialPos = initialPos.ToUpper(); //Convert all commands to uppercase
            string[] positionXY = initialPos.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (positionXY.Length != 3)
                throw new MRSquadException("Rover position must consist of two coordinates (X and Y)");

            int parsedX;
            if (!Int32.TryParse(positionXY[0].ToString(), out parsedX))
                throw new MRSquadException("Rover X position must be an integer");
            _x = parsedX;

            int parsedY;
            if (!Int32.TryParse(positionXY[1].ToString(), out parsedY))
                throw new MRSquadException("Rover Y position must be an integer");
            _y = parsedY;

            if (positionXY[2].ToString() != "N" && positionXY[2].ToString() != "S" && positionXY[2].ToString() != "W" && positionXY[2].ToString() != "E")
                throw new MRSquadException("Rover initial direction must be N, S, W or E");
            _direction = positionXY[2].ToString()[0];



            if (_x < 0 || _y < 0 || _x > planet._width || _y > planet._height)
                throw new MRSquadException("Rover is out of surface boundaries");


            MoveRover(moveCommands);
        }

        private void MoveRover(string moveCommands)
        {
            moveCommands = moveCommands.ToUpper(); //Convert all commands to uppercase
            moveCommands = moveCommands.Replace(" ", ""); //Remove unnecessary spaces

            char[] splittedCommands = moveCommands.ToCharArray();

            foreach (var moveCommand in splittedCommands)
            {
                switch ((MoveCommands)moveCommand)
                {
                    case MoveCommands.Move:
                        MoveForward();
                        break;
                    case MoveCommands.Left:
                        TurnLeft();
                        break;
                    case MoveCommands.Right:
                        TurnRight();
                        break;

                    default:
                        throw new MRSquadException("Unexpected move command in command list");
                }
            }
        }

        private void MoveForward()
        {
            switch ((Directions)_direction)
            {
                case Directions.North:
                    _y += 1;
                    break;
                case Directions.South:
                    _y -= 1;
                    break;

                case Directions.East:
                    _x += 1;
                    break;
                case Directions.West:
                    _x -= 1;
                    break;
            }
        }

        private void TurnLeft()
        {
            switch ((Directions)_direction)
            {
                case Directions.North:
                    _direction = (char)Directions.West;
                    break;
                case Directions.South:
                    _direction = (char)Directions.East;
                    break;

                case Directions.East:
                    _direction = (char)Directions.North;
                    break;
                case Directions.West:
                    _direction = (char)Directions.South;
                    break;
            }
        }

        private void TurnRight()
        {
            switch ((Directions)_direction)
            {
                case Directions.North:
                    _direction = (char)Directions.East;
                    break;
                case Directions.South:
                    _direction = (char)Directions.West;
                    break;

                case Directions.East:
                    _direction = (char)Directions.South;
                    break;
                case Directions.West:
                    _direction = (char)Directions.North;
                    break;
            }
        }

        public string PrintFinalPositionAndHeading()
        {
            return $"{_x} {_y} {_direction}";

        }

    }
}
