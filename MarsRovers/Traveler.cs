using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Traveler:Command
    {
        // Constructor
        #region Constructor
        public Traveler(string[] location, string[] border)
        {
            robotXPoint = Int16.Parse(location[0]);
            robotYPoint = Int16.Parse(location[1]);
            robotDirection = location[2];
            topXPoint = Int16.Parse(border[0]);
            topYPoint = Int16.Parse(border[1]);
        }
        #endregion
        #region Move
        public void Move(char[] commandList)
        {
            foreach (var command in commandList)
            {
                switch (command)
                {
                    case 'L':
                        LeftRotation();
                        break;
                    case 'R':
                        RightRotation();
                        break;
                    case 'M':
                        ForwardMovement();
                        break;
                    default:
                        Console.WriteLine(" ' "+command+"' Invalid Command");
                        break;
                }
            }
            PrintLocation();
        }
        #endregion
    }
}
