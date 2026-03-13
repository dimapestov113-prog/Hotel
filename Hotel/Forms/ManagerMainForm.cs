using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm(ConnectDB db, Employee employee)
        {
            InitializeComponent();
            lblUser.Text = $"Менеджер: {employee.Name}";
            lblDate.Text = $"{DateTime.Now:dd:MM:yyyy}";
        }
    }
}
