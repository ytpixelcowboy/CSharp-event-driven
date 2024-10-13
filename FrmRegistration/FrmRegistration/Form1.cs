namespace FrmRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cbox_program.Text;
            StudentInfoClass.FirstName = txt_firstName.Text;
            StudentInfoClass.LastName = txt_lastName.Text;
            StudentInfoClass.MiddleName = txt_middleName.Text;
            StudentInfoClass.Address = txt_address.Text;
            StudentInfoClass.StudentNo = Convert.ToInt64(txt_studentNo.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txt_contactNo.Text);
            StudentInfoClass.Age = Convert.ToInt64(txt_age.Text);

            FrmConfirm frmConfirm = new FrmConfirm();

            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                frmConfirm.ShowDialog(this);
                frmConfirm.Dispose();
            }
        }
    }
}
