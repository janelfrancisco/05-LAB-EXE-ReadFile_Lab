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

namespace ReadFile_Lab
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string program = txtprogram.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string middleInitial = txtMiddleInitial.Text;
            string age = txtAge.Text;
            string birthday = txtBirthday.Text;
            string contactNo = txtContactNo.Text;
            string gender = txtGender.Text;



            string relativePath = @"..\..\Text Files_Galisfrancisco";
            string docPath = Path.GetFullPath(relativePath);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, txtStudentNo.Text + ".txt")))
            {
                outputFile.WriteLine("Student Number: " + studentNo);

                outputFile.WriteLine("Program: " + program);
                outputFile.WriteLine("Full Name: " + firstName + " " + middleInitial + " " + lastName);
                outputFile.WriteLine("Age: " + age);
                outputFile.WriteLine("Birthday: " + birthday);
                outputFile.WriteLine("Gender: " + gender);
                outputFile.WriteLine("Contact No.: " + contactNo);
            }

            MessageBox.Show("Student Registered in" + docPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.Show();
            this.Hide();
        }
    }
}
