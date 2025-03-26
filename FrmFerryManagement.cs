using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferry_System
{
    public partial class FrmFerryManagement : Form
    {
        private FerryStack ferryStack = new FerryStack();

        public FrmFerryManagement()
        {
            InitializeComponent();
            ferryStack = new FerryStack();
        }

        // private void label1_Click(object sender, EventArgs e)

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string driverName = txtDriverName.Text;
                string registrationNumber = txtRegNumber.Text;
                string vehicleType = txtVehicleType.Text;
                int NumberOfPassengers = Convert.ToInt32(txtPassengerNumber.Text);

                if (!int.TryParse(txtPassengerNumber.Text, out NumberOfPassengers))
                {
                    MessageBox.Show("Invalid passenger count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ferryStack.Count >= 12)
                {
                    MessageBox.Show("Ferry is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string errorMessage = DateTime.Now.ToString() + " _ Ferry full. Vehicle details: {newNode.Details()} ";
                    File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "ErrorLog.txt"), errorMessage + Environment.NewLine);
                    return;
                }

                VehicleNode newNode = new VehicleNode(driverName, registrationNumber, vehicleType, NumberOfPassengers);

                ferryStack.Push(newNode);
                lblOutput.Text = "Vehicle added to ferry" + newNode.Details();
            }

            catch (Exception ex)

            {
                string errorMessage = "Error adding vehicle: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string filePath = Path.Combine(Environment.CurrentDirectory, "ErrorLog.txt");
                File.AppendAllText(filePath, errorMessage + Environment.NewLine);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the ferry is empty first
                if (ferryStack.IsEmpty())
                {
                    MessageBox.Show("The ferry is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Remove the top vehicle from the ferry
                VehicleNode removedVehicle = ferryStack.Pop();

                string message = "Vehicle removed: " + removedVehicle.Details();
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Error handling
                string errorMessage = "Error removing vehicle: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the ferry is empty
                if (ferryStack.IsEmpty())
                {
                    lblOutput.Text = "The ferry is empty.";
                    return;
                }

                // Create a string to store the list of vehicles
                string vehicleList = "Current Vehicles on Ferry:\n";

                // Get a reference to the top of the stack
                VehicleNode current = ferryStack.Peek();

                // Loop through all vehicles on the ferry and add their information to the output.
                while (current != null)
                {
                    vehicleList += current.Details() + "\n";
                    current = current.Prev;
                }

                // Display the list of vehicles 
                lblOutput.Text = vehicleList;

            }
            catch (Exception ex)
            {
                string errorMessage = "Error listing vehicles: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the ferry is empty
                if (ferryStack.IsEmpty())
                {
                    lblOutput.Text = "The ferry is empty.";
                    return;
                }
                // Display the number of vehicles on the ferry
                lblOutput.Text = $"Number of vehicles on the ferry: {ferryStack.Count}";
            }
            catch (Exception ex)
            {
                string errorMessage = "Error counting vehicles: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log the error to the file
                string filePath = Path.Combine(Environment.CurrentDirectory, "ErrorLog.txt");
                File.AppendAllText(filePath, errorMessage + Environment.NewLine);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the ferry is empty
                if (ferryStack.IsEmpty())
                {
                    lblOutput.Text = "The ferry is empty.";
                    return;
                }

                // Create a string to store the list of vehicles
                string vehicleList = "Current Vehicles on Ferry:\n";

                // Get a reference to the top of the stack
                VehicleNode current = ferryStack.Peek();

                while (current != null)
                {
                    vehicleList += current.Details() + "\n";
                    current = current.Prev;
                }

                // Display the list of vehicles
                lblOutput.Text = vehicleList;

            }
            catch (Exception ex)
            {
                string errorMessage = "Error viewing vehicles: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log the error 
                string filePath = Path.Combine(Environment.CurrentDirectory, "ErrorLog.txt");
                File.AppendAllText(filePath, errorMessage + Environment.NewLine);
            }
        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected vehicle index from the NuD control
                int selectedIndex = (int)nudVehicleIndex.Value - 1;

                VehicleNode vehicle = ferryStack.Interrogate(selectedIndex);

                string vehicleDetailsMessage = "Vehicle Details:\n" + vehicle.ToString();
                MessageBox.Show(vehicleDetailsMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                string errorMessage = $"An unexpected error occurred while examining the vehicle: {ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log the error 
                string filePath = Path.Combine(Environment.CurrentDirectory, "ErrorLog.txt");
                File.AppendAllText(filePath, errorMessage + Environment.NewLine);

            }

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the ferry is empty
                if (ferryStack.IsEmpty())
                {
                    MessageBox.Show("The ferry is empty.", "Information", MessageBoxButtons.OK);
                    return; // Exit the method if the ferry is empty
                }

                VehicleNode topVehicle = ferryStack.Peek();
                string vehicleDetails = topVehicle.Details();
                MessageBox.Show("Top Vehicle Details:\n" + vehicleDetails, "Peek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errorMessage = "An unexpected error occurred while peeking: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log the error 
                string filePath = Path.Combine(Environment.CurrentDirectory, "ErrorLog.txt");
                File.AppendAllText(filePath, errorMessage + Environment.NewLine);

            }


        }

        private void btnFindbyReg_Click(object sender, EventArgs e)
        {
                try
                {
                // Get the registration number from text box
                string registration = txtRegNumber.Text.Trim();

                    VehicleNode vehicle = ferryStack.FindByRegistration(registration);

                    if (vehicle != null)
                    {
                        // If a matching vehicle is found, display its details
                        string vehicleDetails = vehicle.ToString();
                        MessageBox.Show("Vehicle Details:\n" + vehicleDetails, "Vehicle Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If no vehicle is found with the registration number
                        MessageBox.Show("No vehicle found with that registration number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    
                    string errorMessage = "An error occurred while finding the vehicle: " + ex.Message;
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnFindbyDriver_Click(object sender, EventArgs e)
        {
            try
            {
                
                string driverName = txtDriverName.Text.Trim();

               
                VehicleNode vehicle = ferryStack.FindByDriver(driverName);

                if (vehicle != null)
                {
                    
                    string vehicleDetails = vehicle.ToString(); 
                    MessageBox.Show("Vehicle Details:\n" + vehicleDetails, "Vehicle Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   
                    MessageBox.Show("No vehicle found with the specified driver.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                
                string errorMessage = "An error occurred while finding the vehicle by driver: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindbyVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                
                string vehicleType = txtVehicleType.Text.Trim();

                
                VehicleNode vehicle = ferryStack.FindByVehicleType(vehicleType);

                if (vehicle != null)
                {
                    
                    string vehicleDetails = vehicle.ToString(); 
                    MessageBox.Show("Vehicle Details:\n" + vehicleDetails, "Vehicle Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    MessageBox.Show("No vehicle found with the specified type.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                
                string errorMessage = "An error occurred while finding the vehicle by type: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }
    

           
           

            

            
        
    


    
    




