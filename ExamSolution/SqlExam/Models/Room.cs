﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExam.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
    }
}
