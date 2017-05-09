using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lesson2_Project
{
    public class CreditExercise_3 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public CreditExercise_3()
        {
        }

        public string subString(string convertedString)
        {

            // Create variable outside try/catch to capture return value
            string returnValue = "null";

            // Error handling
            try
            {
                // Grab the first three letter of input word
                string subString = convertedString.Substring(0, 3);

                // Convert three letters to upper case
                string functionReturnValue = subString.ToUpper();

                // Variable to be used outside of try/catch
                returnValue = functionReturnValue;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Display error message
            }

            return returnValue;

        }

        public void convertString()
        {
            string strChoice = Interaction.InputBox("Please enter a string"); // Display input box to user

            MessageBox.Show(subString(strChoice)); // Sisplay message box with substring
        }

        protected override void OnClick()
        {
            convertString();
        }

        protected override void OnUpdate()
        {
        }
    }
}
