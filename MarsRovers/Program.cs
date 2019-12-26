using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determination of maximum coordinate point.
            Console.Write("Enter the maximum coordinate point: ");
            string[] maxCoordinate = Console.ReadLine().ToUpper().Split(' ');

            // Get location information and command list for each robot.
            while (true)
            {
                // Determination of the initial coordinate of the robot.
                Console.Write("Enter the start coordinates of the robot: ");
                string[] startPoint = Console.ReadLine().ToUpper().Split(' ');

                // Definition of commands
                Console.Write("Enter the motion command list: ");
                char[] commandList = Console.ReadLine().ToUpper().ToCharArray();

                try
                {
                    Traveler traveler = new Traveler(startPoint, maxCoordinate);
                    traveler.Move(commandList);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInput string is not correct ! Please check \n" + "Sample Input \n" + "5 5 \n" + "1 2 N \n" + "LMLMLMLMM");
                }
                Console.ReadKey();
            }

        }
    }
}
