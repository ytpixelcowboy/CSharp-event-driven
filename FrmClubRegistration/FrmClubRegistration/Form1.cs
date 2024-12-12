namespace FrmClubRegistration
{
    public partial class Form1 : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        string FirstName, MiddleName, LastName, Gender, Program;
        long StudentId;

        public Form1()
        {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();
        }

        public int RegistrationID()
        {
            count += 1;
            return count;
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView.DataSource = clubRegistrationQuery.bindingSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.RegisterStudent(RegistrationID(), Convert.ToInt64(tbox_studentId.Text), tbox_firstName.Text, tbox_middleName.Text, tbox_lastName.Text, Convert.ToInt32(tbox_age.Text), cbox_gender.Text, cbox_program.Text);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            FrmUpdateMember form = new FrmUpdateMember();
            form.ShowDialog();
        }

        private void cbox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
