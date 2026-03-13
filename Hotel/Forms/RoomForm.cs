using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Models;

namespace Hotel.Forms
{
    public partial class RoomForm : Form
    {
        private readonly Room _room;
        public RoomForm(Room room,ConnectDB _db)
        {
            InitializeComponent();
            _room = room;
            LoadComboBoxes(_db);
        }
        public void LoadComboBoxes(ConnectDB _db)
        {
            comboBox1.Controls.Clear();
            var guests = _db.Guests.Select(g => new
            {
                Id = g.Id,
                Name = g.Name,
                Passport = g.Passport
            }).ToList();
            comboBox1.DataSource = guests;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
