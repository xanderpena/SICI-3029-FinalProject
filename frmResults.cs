using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();
            //dataGridViewResults.DataSource =

            using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(@"C:\Users\17879\OneDrive\Universidad\Fall 21-22\SICI-3029/Course_Scheduling_Data.csv"))
            {
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();

                    foreach (string field in fields)
                    {

                    }
                }
            }
        }
    }
}
