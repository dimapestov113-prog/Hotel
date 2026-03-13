using Hotel.Forms;
using Hotel.Models;

namespace Hotel
{
    public partial class LoginForm : Form
    {
        private readonly ConnectDB db = new ConnectDB();
        public LoginForm()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
        }
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (login != null && password != null)
            {
                Employee employee = db.Employees.FirstOrDefault(e => e.Login == login && e.Password == password);
                if (employee != null)
                {
                    switch (employee.Role)
                    {
                        case "Administrator":
                            var adminForm = new AdminMainForm(db, employee);
                            adminForm.Show();
                            this.Hide();
                            break;
                        case "Manager":
                            var managerForm = new ManagerMainForm(db, employee);
                            managerForm.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Ненайден пользователь");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Ненайден пользователь");
                }
            }
        }
    }
}
