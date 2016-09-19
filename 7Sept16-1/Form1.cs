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

        // Order's time and date
        string dateTime = DateTime.Now.ToString();
        // Open order file
        StreamWriter orderOut = File.AppendText("Orders.txt");

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

                // Write the order in a file
                if (!exitWasClicked == true)
                {
                    orderOut.WriteLine(dateTime);
                }
                orderOut.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ice Cream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

        }

        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {        
            StreamWriter orderOut = File.AppendText("Orders.txt");
            foreach (string item in lbxFlavors.SelectedItems)
            {
                lbxFlavor.Text = "Enjoy your " + lbxFlavors.SelectedItem.ToString() + " cone!";

                // Write the flavor seleccted in a file        
                orderOut.WriteLine(lbxFlavors.SelectedItem.ToString());
            }
            orderOut.Close();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Open order
            //StreamReader OrderOut = File.OpenText("Orders.txt");

            exitWasClicked = true;
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
            MessageBoxButtons.OKCancel
        }
    }
}
