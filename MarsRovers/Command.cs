using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*    Motion Commands    */
namespace MarsRovers
{
    public class Command
    {
        public int topXPoint;
        public int topYPoint;
        public int robotXPoint;
        public int robotYPoint;
        public string robotDirection;
        // Turn left 90 degrees
        #region LeftRotation
        protected void LeftRotation()
        {
            switch (robotDirection)
            {
                case "N":
                    robotDirection = "W";
                    break;
                case "W":
                    robotDirection = "S";
                    break;
                case "S":
                    robotDirection = "E";
                    break;
                case "E":
                    robotDirection = "N";
                    break;
            }
        }
        #endregion
        // Turn right 90 degrees
        #region RightRotation
        protected void RightRotation()
        {
            switch (robotDirection)
            {
                case "N":
                    robotDirection = "E";
                    break;
                case "W":
                    robotDirection = "N";
                    break;
                case "S":
                    robotDirection = "W";
                    break;
                case "E":
                    robotDirection = "S";
                    break;
            }
        }
        #endregion
        // one step forward
        #region ForwardMovement
        protected void ForwardMovement()
        {
            switch (robotDirection)
            {
                case "N":
                    if (robotYPoint < topYPoint)
                        robotYPoint += 1;
                    break;
                case "W":
                    if (robotXPoint > 0)
                        robotXPoint -= 1;
                    break;
                case "S":
                    if (robotYPoint > 0)
                        robotYPoint -= 1;
                    break;
                case "E":
                    if (robotXPoint < topXPoint)
                        robotXPoint += 1;
                    break;
            }
        }
        #endregion
        // print location information
        #region PrintLocation
        protected void PrintLocation()
        {
            Console.Write("X Point: " + robotXPoint + "| Y Point: " + robotYPoint + "| Direction : " + robotDirection + "\n");
        }
        #endregion
    }
}
