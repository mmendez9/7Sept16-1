using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Sept16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool exitWasClicked = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            string flavor;
            try
            {
                // Open the data file for reading
                StreamReader inputFile = File.OpenText("flavors.txt");

                // Read all lines in the file
                while (!inputFile.EndOfStream)
                {
                    // Read the next line
                    flavor = inputFile.ReadLine();

                    // Add it to the list box
                    lbxFlavors.Items.Add(flavor);
                }

                // Close the file 
                inputFile.Close();

                // Display the number of flavors
                lblFlavors.Text = lbxFlavors.Items.Count + " flavors available today";

                 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ice Cream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

        }

        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxFlavor.Text = "Enjoy your " + lbxFlavors.SelectedItem.ToString() + " cone!";

            // Order's time and date
                 string dateTime = DateTime.Now.ToString();
                 StreamWriter orderOut = File.AppendText("Orders.txt");

                for (int a = 1; a <= 10; a++)
                {
                    // Write the order in a file
                    orderOut.WriteLine("Order #" + a + " " + dateTime);
                    if (!exitWasClicked == true)
                    {
                        orderOut.WriteLine(lbxFlavors.SelectedItem.ToString());
                    }
                    else
                    {
                        orderOut.Close();
                    }
                    }
                orderOut.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            exitWasClicked = true;
            Close();
            
        }

    }
}
