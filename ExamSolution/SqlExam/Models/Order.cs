using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExam.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Room_id { get; set; }
        public int User_id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Title { get; set; }


    }
}
