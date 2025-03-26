using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferry_System
{
    public class VehicleNode
    {
         
        public string DriverName;
        public string RegistrationNumber;
        public string VehicleType;
        public int NumberOfPassengers;
        public VehicleNode Prev { get; set; }

        public VehicleNode(string driverName, string registrationNumber, string vehicleType, int numberOfPassengers)
        {
            DriverName = driverName;
            RegistrationNumber = registrationNumber;
            VehicleType = vehicleType;
            NumberOfPassengers = numberOfPassengers;
        }

        public override string ToString()
        {
            string output = "Driver: " + DriverName + "\n" +
                            "Registration: " + RegistrationNumber + "\n" +
                            "Vehicle Type: " + VehicleType + "\n" +
                            "Passengers: " + NumberOfPassengers;
            return output;
        }

        public string driverName
        {
            get
            {
                return DriverName;
            }
        }

        public string vehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = value;
            }
        }

        public int numberOfPassengers
        {
            get
            {
                return numberOfPassengers;
            }
            set
            {
                numberOfPassengers = value;
            }

        }

        public string registrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }

        public VehicleNode prev
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }

        }

        public string Details()
        {
            return $"Driver: {DriverName}, Vehicle Type: {VehicleType}, Registration: {RegistrationNumber}, Passengers: {NumberOfPassengers}";

        }//details

    }
}
