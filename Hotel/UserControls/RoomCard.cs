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
    public partial class RoomCard : UserControl
    {
        private Room _room;
        private ConnectDB _db;
        public RoomCard(ConnectDB db)
        {
            _db = db;
            InitializeComponent();
        }
        public void SetData(Room room)
        {
            _room = room;
            lblFloor.Text = "Этаж:"+ room.Floor;
            lblNumber.Text = "Номер:"+ room.Number;
            lblPrice.Text = Convert.ToString(room.Price)+ " ₽";
            lblStatus.Text = room.Status;
            lblType.Text = room.RoomType;
        }
        public void RoomCard_Click(object sender,EventArgs e)
        {
            using (var editform = new RoomForm(_room,_db))
            {
                editform.ShowDialog();
                var form = ParentForm as AdminMainForm;
                form!.LoadRooms(_db);
            }
        }

    }
}
