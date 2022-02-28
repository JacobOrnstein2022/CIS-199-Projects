// Grading ID; S1918
// Program 4
// Due Date: 4/20/2020
// Course: CIS-199-75
// Program Description: sets property values for the ground package class and creates a method to calculate zoning distance and display property values when the correct input is received
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class GroundPackage
    {
        private int _originZip; // 00000 - 99999 default 40204
        private int _destinationZip; // 00000 - 99999 default 60606
        private double _length; // >0 default 12
        private double _width; // >0 default 12
        private double _height; // >0 default 12
        private double _weight; // >0 default 12

        // Precondition:  0 < originZip <= 99999
        //                0 < destinationZip <= 99999
        //                0 < length
        //                0 < width
        //                0 < height
        //                0 < weight
        // Postcondition: Shipping Information is initialized with the specefied information (zips and product demensions)

        public GroundPackage(int originZip, int destinationZip, double length, double width, double height, double weight)
        {
            OriginZip = originZip; // Sets OriginZip property
            DestinationZip = destinationZip; // Sets DestinationZip property
            Length = length; // Sets Length property
            Width = width; // Sets Width property
            Height = height; // Sets Height property
            Weight = weight; // Sets Weight property
        }

        // Precondition:  0 < originZip <= 99999
        //                0 < destinationZip <= 99999
        //                0 < length
        //                0 < width
        //                0 < height
        //                0 < weight
        // Postcondition: Shipping Information is changed to the specefied information (zips and product demensions)

        const int ZIP_UPPER_LIMIT = 99999;
        const int ZIP_LOWER_LIMIT = 00000;
        const int O_ZIP_DEFAULT = 40204;
        const int D_ZIP_DEFAULT = 60606;
        const int DEMENSION_DEFAULT = 12;
        const int ZONE_FACTOR = 10000;

        public int OriginZip
        {
            // Precondition:  None
            // Postcondition: The originZip has been returned
            get
            { return _originZip; }

            // Precondition:  00000 < value <= 99999
            // Postcondition: The originZip has been set to specified value

            set
            {
                if (value > ZIP_LOWER_LIMIT && value <= ZIP_UPPER_LIMIT)
                    _originZip = value;
                else
                    _originZip = O_ZIP_DEFAULT; // sets default value
            }
        }
        public int DestinationZip
        {
            // Precondition:  None
            // Postcondition: The destinationZip has been returned
            get
            { return _destinationZip; }

            // Precondition:  00000 < value <= 99999
            // Postcondition: The destinationZip has been set to specified value

            set
            {
                if (value > ZIP_LOWER_LIMIT && value <= ZIP_UPPER_LIMIT)
                    _destinationZip = value;
                else
                    _destinationZip = D_ZIP_DEFAULT; // sets default value
            }
        }
        public double Length
        {
            // Precondition:  None
            // Postcondition: The length has been returned
            get
            { return _length; }

            // Precondition:  0 < value
            // Postcondition: The length has been set to specified value

            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = DEMENSION_DEFAULT; // sets default value
            }
        }
        public double Width
        {
            // Precondition:  None
            // Postcondition: The width has been returned
            get
            { return _width; }

            // Precondition:  0 < value
            // Postcondition: The width has been set to specified value

            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = DEMENSION_DEFAULT; // sets default value
            }
        }
        public double Height
        {
            // Precondition:  None
            // Postcondition: The height has been returned
            get
            { return _height; }

            // Precondition:  0 < value
            // Postcondition: The height has been set to specified value

            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = DEMENSION_DEFAULT; // sets default value
            }
        }
        public double Weight
        {
            // Precondition:  None
            // Postcondition: The weight has been returned
            get
            { return _weight; }

            // Precondition:  0 < value
            // Postcondition: The weight has been set to specified value

            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = DEMENSION_DEFAULT; // sets default value
            }
        }
        public int ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The zoneDistance has been returned
            get
            {
                int _zoneDistance; // Positive intiger derived from Origin and Destination ZIPs
                _zoneDistance = _originZip / ZONE_FACTOR - _destinationZip / ZONE_FACTOR;
                return Math.Abs(_zoneDistance);
            }

            // Precondition:  0 < value
            // Postcondition: The weight has been set to specified value

        }


        public virtual double CalcCost() // method to calculate cost based on shipping information
        {
            const double SIZE_COST_FACTOR = .2; // set constant size factor for calculation
            const double WEIGHT_COST_FACTOR = .35; // set constant weight factor for calculation
            double cost = SIZE_COST_FACTOR * (Length + Width + Height) + WEIGHT_COST_FACTOR * (ZoneDistance + 1) * (Weight); // calculates shipping cost
            return cost;
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the shipping information for a package
        public override string ToString() 
        {
            return $"Origin ZIP: {OriginZip}{Environment.NewLine}" +
                   $"Destination ZIP: {DestinationZip}{Environment.NewLine}" +
                   $"Length: {Length}{Environment.NewLine}" +
                   $"Width: {Width}{Environment.NewLine}" +
                   $"Height: {Height}{Environment.NewLine}" +
                   $"Weight: {Weight}{Environment.NewLine}" +
                   $"Zone Distance: {ZoneDistance}";
        }
    }
}
