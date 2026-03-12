using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public enum PaymentStatus
    {
        Pending,
        Completed,
        Refunded,
        Failed
    }
    public enum PaymentMethod
    {
        Cash,
        Card,
        Transfer,
        Online
    }
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
    }
}