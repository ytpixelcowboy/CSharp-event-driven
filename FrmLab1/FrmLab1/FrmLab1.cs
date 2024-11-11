namespace FrmLab1
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmFileName frmFileName = new frmFileName();
            frmFileName.ShowDialog();

            string getInput = txtInput.Text;


            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            frmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);

                FrmRegistration fr = new FrmRegistration();
                fr.Show();
            }

            
        }

        private void FrmLab1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
