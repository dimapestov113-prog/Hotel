using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Hotel.Forms
{
    public partial class AdminMainForm : Form
    {
        private readonly ConnectDB _db;
        public AdminMainForm(ConnectDB db, Employee employee)
        {
            InitializeComponent();
            lblUser.Text = $"Администратор: {employee.Name}";
            lblDate.Text = $"{DateTime.Now:dd:MM:yyyy}";
            LoadRooms(db);
        }
        public void LoadRooms(ConnectDB db)
        {
            flowLayoutPanel1.Controls.Clear();
            var rooms = db.Rooms.ToList();
            foreach(var room in rooms)
            {
                var card = new RoomCard(db);
                card.SetData(room);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
    