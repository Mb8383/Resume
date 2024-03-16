using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities.Contact
{
    public class Contacts
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
        public bool IsseenAdmin { get; set; }=false;
    }
}
