using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE3
{
    public partial class Form1 : Form
    {
        private static string path = System.IO.Path.GetFullPath(@"..\..\..\") + "ClassList.txt";

        string[] ProductList;

        string name;
        string del = ",";

        public Form1()
        {
            InitializeComponent();
        }
        public void RunDelimiter()
        {

            name = txtStudentName.Text;

            ProductList = name.Split(del);

            foreach (var Product in ProductList)
            {
                ClassList.Items.Add(Product);
            }
            txtStudentName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {
                RunDelimiter();
            }
            else
            {
                MessageBox.Show("Values can't be empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassList.Items.Clear();
        }
    }
}
