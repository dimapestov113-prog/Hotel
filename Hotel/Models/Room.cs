using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string RoomType { get; set; }
        public string Floor { get; set; }
        public string Status { get; set; } 
        public decimal Price { get; set;}

    }
}
