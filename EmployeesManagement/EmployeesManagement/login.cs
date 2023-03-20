namespace EmployeesManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primary primaryPage = new primary();
            primaryPage.Show();
            this.Hide();
            
            
        }
    }
}