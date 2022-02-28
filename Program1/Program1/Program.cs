// Grading Id: S1918
// Program 1
// Due Date: 2/11/2020
// Course: CIS-199-75
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double length;
            double price;
            double total;
            double sqYards;
            double carpetCost;
            double paddingCost;
            double laborCost;
            int padding;
            int firstRoom;

            const int firstRoomCharge= 75; // first room fee
            const double labor= 4.25; // labor charge per square yard
            const int sqYardConversion = 9; // for sq yard conversion factor
            const double padCostPerSqYard = 2.5; // padding cost per square yard
            const double excess = 1.1; // excess multiple for carpet and padding

            WriteLine("Welcome to the Handy-Dandy Carpet Estimator");
            WriteLine("");

            Write("Enter the max width of the room (in feet): ");
            width = double.Parse(ReadLine()); // width in feet input

            Write("Enter the max length if room (in feet): ");
            length = double.Parse(ReadLine()); // length in feet input

            Write("Enter the carpet price (per sq. yard): ");
            price = double.Parse(ReadLine()); // price per square yard

            Write("Enter layers of padding to use (1 or 2): ");
            padding = int.Parse(ReadLine()); // number of padding layers

            Write("Is this the first room? (1 = YES, 0 = NO): ");
            firstRoom = int.Parse(ReadLine()); // first room charge condition

            sqYards = (width * length) / sqYardConversion; // sq yard conversion
            carpetCost = sqYards * price * excess; // total carpet cost
            paddingCost = sqYards * padCostPerSqYard * excess * padding; // total padding cost
            laborCost = (sqYards * labor) + (firstRoomCharge * firstRoom); // labor cost including first room fee
            total = laborCost + paddingCost + carpetCost; // total project cost

            WriteLine("");


            WriteLine($"Sq. Yards Needed: {sqYards:F1}");

            WriteLine($"Carpet Cost: {carpetCost:C}");

            WriteLine($"Padding Cost: {paddingCost:C}");

            WriteLine($"Labor Cost: {laborCost:C}");

            WriteLine($"Total Cost: {total:C}");
        }
    }
}
