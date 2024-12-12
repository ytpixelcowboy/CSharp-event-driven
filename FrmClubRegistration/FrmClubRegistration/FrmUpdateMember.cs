using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private SqlConnection sqlConnect;
        private SqlDataReader sqlReader;
        public string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        int age;

        public FrmUpdateMember()
        {
            InitializeComponent();
            connectionString = @"Server=Jordee\SQLEXPRESS;Database=ClubDB;Trusted_Connection=True;";
            sqlConnect = new SqlConnection(connectionString);

            string ViewClubMembers = "SELECT StudentId, FirstName FROM ClubMembers";
            SqlCommand sqlCommand = new SqlCommand(ViewClubMembers, sqlConnect);
            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                cbox_studentIds.Items.Add(sqlReader["StudentId"].ToString());
            }
            sqlReader.Close();
            sqlConnect.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = @StudentID";
            SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnect);
            sqlConnect.Open();
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.Int).Value = cbox_studentIds.Text;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = tbox_firstName.Text;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = tbox_middleName.Text;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = tbox_lastName.Text;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Convert.ToInt32(tbox_age.Text);
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbox_gender.Text;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = cbox_program.Text;
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            MessageBox.Show("Info for " + cbox_studentIds.Text + " has been updated successfully");
            Close();

        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbox_studentIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }


        private void DisplayData()
        {
            string ViewClubMembers = "SELECT * FROM ClubMembers WHERE StudentId = @StudID";
            SqlCommand sqlCommand = new SqlCommand(ViewClubMembers, sqlConnect);
            sqlConnect.Open();
            sqlCommand.Parameters.Add("@StudID", SqlDbType.Int).Value = cbox_studentIds.Text;
            sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.Read() != null)
            {
                tbox_firstName.Text = sqlReader["FirstName"].ToString();
                tbox_lastName.Text = sqlReader["LastName"].ToString();
                tbox_middleName.Text = sqlReader["MiddleName"].ToString();
                tbox_age.Text = sqlReader["Age"].ToString();
                cbox_gender.Text = sqlReader["Gender"].ToString();
                cbox_program.Text = sqlReader["Program"].ToString();
            }

            sqlReader.Close();
            sqlConnect.Close();
        }
    }
}
