using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // dataGridViewResults.DataSource = 
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close the program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter Couser Code";

            label2.Text = "Enter Professor Name";

            label3.Text = "Enter the Classroom";

            label4.Text = "Search by Options/ Modes";


            // TODO

            //using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(@"C:\Users\17879\OneDrive\Universidad\Fall 21-22\SICI-3029/Course_Scheduling_Data.csv"))
            //{
            //    parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
            //    parser.SetDelimiters(",");
            //    while (!parser.EndOfData)
            //    {
            //        //Processing row
            //        string[] fields = parser.ReadFields();
                    
            //        foreach (string field in fields)
            //        {

            //        }
            //    }
            //}

            DataTable table = ConvertCSVToDataTable(@"C:\Users\17879\OneDrive\Universidad\Fall 21-22\SICI-3029/Course_Scheduling_Data.csv");
            //dataGridViewResults.DataSource = table;
            BindingSource BS = new BindingSource();
            BS.DataSource = table;
            dataGridViewResults.DataSource = BS;

            dataGridViewResults.Refresh();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public static DataTable ConvertCSVToDataTable(string fileName)
        {
            char splitChars = ',';

            var table = new DataTable();

            using (TextFieldParser reader = new TextFieldParser(fileName))
            {

                //reader= true;
                var rowdatas = new string[200];
                // get the first row of csv
                string header = reader.ReadLine();
                var fields = header.Split(splitChars);

                foreach (string column in fields)
                {
                    // add columns to new datatable based on first row of csv
                    table.Columns.Add(column);
                }

                string row = reader.ReadLine();
                // read to end
                while (row != null)
                {
                    //if ( row.Contains(",\""))
                    //{
                    //    table.Rows.Add(rowdatas);
                    //    row = reader.ReadLine();
                    //}
                    //else
                    //{
                    //    rowdatas = row.Split(splitChars);
                    //    table.Rows.Add(rowdatas);
                    //    row = reader.ReadLine();
                    //}
                    // add each row to datatable 


                    //}
                    if (row.Contains(",\""))
                    {
                        continue;
                    }
                    else
                    {
                        rowdatas = row.Split(splitChars);
                        table.Rows.Add(rowdatas);
                        row = reader.ReadLine();
                    }
                
                }

                return table;
            }
        }
    }
}
