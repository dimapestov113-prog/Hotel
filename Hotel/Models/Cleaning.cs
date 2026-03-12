using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public enum CleaningStatus
    {
        Scheduled,
        InProgress,
        Completed
    }
    public class Cleaning
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CleaningDate { get; set; } = DateTime.Now;
        public CleaningStatus Status { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
    }
}
