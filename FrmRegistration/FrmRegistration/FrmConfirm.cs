using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmRegistration
{

    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName,
        DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress =  new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);


            txt_studentNo.Text = Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
            txt_contactNo.Text = Convert.ToString(DelNumContactNo(StudentInfoClass.ContactNo));
            txt_age.Text = Convert.ToString(DelNumAge(StudentInfoClass.Age));
            txt_lastName.Text = DelLastName(StudentInfoClass.LastName);
            txt_firstName.Text = DelFirstName(StudentInfoClass.FirstName);
            txt_middleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            txt_program.Text = DelProgram(StudentInfoClass.Program);
            txt_address.Text = DelAddress(StudentInfoClass.Address);

        }


    }
}
