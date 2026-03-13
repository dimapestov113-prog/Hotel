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
        private readonly ConnectDB db;
        private readonly Room _room;
        public RoomForm(Room room,ConnectDB _db)
        {
            InitializeComponent();
            _room = room;
            db = _db;
            LoadComboBoxes(_db);
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
        }
        public void dateTimeReload(object sender, EventArgs e)
        {
            string TotalPrice = Convert.ToString((Convert.ToInt32(dateTimePicker2.Value.Day) - Convert.ToInt32(dateTimePicker1.Value.Day)) * _room.Price )+ "₽";
            label6.Text = TotalPrice;
        }
        public void LoadComboBoxes(ConnectDB _db)
        {
            comboBox1.Controls.Clear();
            var guests = _db.Guests.Select(g => new
            {
                Id = g.Id,
                Name = g.Name + g.Surname + g.Middle_name
            }).ToList();
            comboBox1.DataSource = guests;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
           if (comboBox1.SelectedIndex != 0 && dateTimePicker1 != dateTimePicker2 && dateTimePicker2.Value.Date != DateTime.Today && dateTimePicker1.Value.Date < dateTimePicker2.Value.Date )
            {
                try
                {
                    decimal price = Convert.ToDecimal(label6.Text);
                    DateTime dateStart = dateTimePicker1.Value;
                    DateTime dateEnd = dateTimePicker2.Value;
                    int idGuest = Convert.ToInt32(comboBox1.ValueMember);
                    int idRoom = _room.Id;
                    var booking = new Booking
                    {
                        GuestId = idGuest,
                        RoomId = idRoom,
                        DateStart = dateStart,
                        DateEnd = dateEnd,
                        TotalPrice = price
                    };
                    db.Bookings.Add( booking );
                    _room.Status = "Занят";
                    db.SaveChanges();
                    MessageBox.Show("Сохранено");

                }
                catch
                {
                    MessageBox.Show("Ошибка при попытке записать");
                }
            }
           else
            {
                MessageBox.Show("Ошибка в выбранных данных");
            }
        }
    }
}
