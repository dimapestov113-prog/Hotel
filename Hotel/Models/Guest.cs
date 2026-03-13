using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_name { get; set; }
        public string Passport{ get; set; }
    }
}
