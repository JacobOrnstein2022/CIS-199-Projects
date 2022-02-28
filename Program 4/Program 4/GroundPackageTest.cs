// Grading ID; S1918
// Program 4
// Due Date: 4/20/2020
// Course: CIS-199-75
// Program Description: Tests 6 ground packages and changes values in each one to display shipping information and show default values
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class GroundPackageTest
    {
        public static void Main(string[] args)
        {
            // Precondition: None
            // Postcondition: Creates 6 packages and outputs them
            GroundPackage package1 = new GroundPackage(0, 52635, 13.5, 14, 2, 7.5); // Invalid OriginZip
            GroundPackage package2 = new GroundPackage(32587, 0, 13.5, 14, 2, 7.5); // Invalid DestinationZip
            GroundPackage package3 = new GroundPackage(32587, 52635, 0, 14, 2, 7.5); // Invalid Length
            GroundPackage package4 = new GroundPackage(32587, 52635, 13.5, 0, 2, 7.5); // Invalid Width
            GroundPackage package5 = new GroundPackage(32587, 52635, 13.5, 14, 0, 7.5); // Invalid Height
            GroundPackage package6 = new GroundPackage(32587, 52635, 13.5, 14, 2, 0); // Invalid Weight

            GroundPackage[] packageArray = new GroundPackage[6];

            packageArray[0] = package1;
            packageArray[1] = package2;
            packageArray[2] = package3;
            packageArray[3] = package4;
            packageArray[4] = package5;
            packageArray[5] = package6;

            DisplayPackages(packageArray);

            package1.OriginZip = 58956545;
            package2.DestinationZip = 1584525852;
            package3.Length = -3;
            package4.Width = -3;
            package5.Height = -3;
            package6.Weight = -3;

            WriteLine();
            WriteLine();
            WriteLine("Changed Values:");

            DisplayPackages(packageArray);

        }
        public static void DisplayPackages(GroundPackage[] packageArray)
        {
            foreach(GroundPackage package in packageArray)
            {
                WriteLine($"Shipping Information: {package}"); // Displays Shipping Info
                WriteLine($"Cost: {package.CalcCost():C}"); // Displays Shipping Cost
                WriteLine(); // Adds space between packages
            }
        }
    }
}
