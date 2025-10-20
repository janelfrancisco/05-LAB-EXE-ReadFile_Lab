using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFile_Lab
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        // 3.1 The Register button in FrmStudent should go back to the FrmRegistration
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.Show();
            this.Hide();

        }

        // 3.2 The Find button will look for the text file in the specified directory
        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }


        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }

        // 3.3 while the Upload button will only display a message box “Successfully Uploaded!”
        // and will clear the ListView’s existing content.
        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowText.Items.Clear();

        }
    }

    }

