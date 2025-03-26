using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferry_System
{
    public class FerryStack
    {
        
    private VehicleNode top;
    private int count;

        public FerryStack()
        {
            top = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(VehicleNode newNode)
        {
            newNode.Prev = top;
            top = newNode;
            count++;
        }

        public int Count
        {
            get { return count; }
        }

        public string List()
        {
            if (IsEmpty())
            {
                return " The ferry is empty ";
            }

            string output = " Vehicles on the ferry: \n";
            VehicleNode current = top;

            while (current != null)
            {
                output += current.Details() + "\n";
                current = current.Prev;
            }

            return output;
        }

        public VehicleNode Pop()
        {
            if (IsEmpty())
            {
                return null;
            }

            VehicleNode remove = top;
            top = remove.Prev;
            count--;

            return remove;
        }

        public VehicleNode Peek()
        {
            return top;
        }

        public VehicleNode FindByDriver(string driverName)
        {
            if (IsEmpty())
            {
                return null;
            }

            VehicleNode current = top;

            while (current != null)
            {
                if (driverName.Equals(current.DriverName, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Prev          ;
            }

            return null;
        }

        public VehicleNode FindByRegistration(string registration)
        {
            if (IsEmpty())
            {
                return null;
            }

            VehicleNode current = top;

            while (current != null)
            {
                if (registration.Equals(current.RegistrationNumber, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Prev;
            }

            return null;
        }

        public VehicleNode FindByVehicleType(string vehicleType)
        {
            if (IsEmpty())
            {
                return null;
            }

            VehicleNode current = top;

            while (current != null)
            {
                if (vehicleType.Equals(current.VehicleType, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Prev;
            }

            return null;
        }

          public VehicleNode Interrogate(int index)
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Ferry is empty.");
                }

                if (index >= Count)
                {
                    throw new IndexOutOfRangeException("Vehicle index out of range.");
                }

                int currentIndex = 0;
                VehicleNode current = top;

                while (current != null && currentIndex <= index)
                {
                    if (currentIndex == index)
                    {
                        return current;
                    }
                    currentIndex++;
                    current = current.Prev;
                }

                throw new Exception("Unable to find vehicle");
            }

        
    }
}

