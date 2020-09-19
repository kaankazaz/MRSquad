using MRSquad.Library;
using System;
using Xunit;

namespace MRSquad.Test
{
    public class MRSquadTest
    {

        [Fact]
        public void TestMarsRover1()
        {
            //Arrange
            IPlanetSurface mars = new MarsSurface("5 5");
            IVehicle rover1 = new MarsRover("1 2 N", "LMLMLMLMM", mars);

            //Act
            string actResult = rover1.PrintFinalPositionAndHeading();

            //Assert
            Assert.Equal("1 3 N", actResult);
        }

        [Fact]
        public void TestMarsRover2()
        {
            //Arrange
            IPlanetSurface mars = new MarsSurface("5 5");
            IVehicle rover1 = new MarsRover("3 3 E", "MMRMMRMRRM", mars);

            //Act
            string actResult = rover1.PrintFinalPositionAndHeading();

            //Assert
            Assert.Equal("5 1 E", actResult);
        }

        [Fact]
        public void TestMarsSquad()
        {
            //Arrange
            IPlanetSurface mars = new MarsSurface("5 5");
            Squad mrSquad = new Squad(mars);

            mrSquad.AddVehicle("1 2 N", "LMLMLMLMM");
            mrSquad.AddVehicle("3 3 E", "MMRMMRMRRM");

            //Act
            string actResult1 = mrSquad[0].PrintFinalPositionAndHeading();
            string actResult2 = mrSquad[1].PrintFinalPositionAndHeading();

            //Assert
            Assert.Equal("1 3 N", actResult1);
            Assert.Equal("5 1 E", actResult2);
        }
    }
}
