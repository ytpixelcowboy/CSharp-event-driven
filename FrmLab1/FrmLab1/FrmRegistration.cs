using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,"studentInfo.txt")))
            {
                string f_studNo = "Studen No.: " + txtStudentNo.Text;
                string f_name = "Full Name: " +  txtLastName.Text + ", " + txtFirstName.Text + " " + txtMI.Text + ".";
                string f_Program = "Program: " + cbProgram.Text;
                string f_age = "Age: " + txtAge.Text;
                string f_birthDay = "Birthday: " + dtpBirthday.Value.ToString();
                string f_contact = "Contact No.:" + txtContact.Text;

                outputFile.WriteLine(f_studNo + "\n" + f_name + "\n" + f_Program + "\n" + f_age+ "\n" + f_birthDay + "\n" + f_contact);
                //Console.WriteLine(getInput);
            }
        }
    }
}
