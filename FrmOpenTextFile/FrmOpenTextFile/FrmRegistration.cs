using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmOpenTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord form1 = new FrmStudentRecord();
            form1.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "data.txt")))
            {
                string f_studNo = txtStudentNo.Text;
                string f_firstName = txtFirstName.Text;
                string f_lastName = txtLastName.Text;
                string f_middleName = txtMiddleName.Text;
                string f_Program = cboxProgram.Text;
                string f_age = txtAge.Text;
                string f_birthDay = dateTimePicker1.Value.ToString();
                string f_contact = txtContactNo.Text;

                outputFile.WriteLine(
                    f_studNo + "\n" +
                    f_firstName + "\n" +
                    f_lastName + "\n" +
                    f_middleName + "\n" +
                    f_Program + "\n" +
                    f_age + "\n" +
                    f_birthDay + "\n" +
                    f_contact + "\n"
                    );
                //Console.WriteLine(getInput);
            }
        }
    }
}
