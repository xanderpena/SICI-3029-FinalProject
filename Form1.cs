using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
            //    sr.ReadToEnd();
            //}

            Form2 f2 = new Form2();
            f2.ShowDialog();

            this.Close();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "PROJECT NAME";

            label2.Text = "This project was done by Alexander and Kiara";

            label3.Text = "Click the next button if you want to continue";

            //StreamReader sr = new StreamReader(FilePath);
            //importingData = new Account();



        }
    }
}
