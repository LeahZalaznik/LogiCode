﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class User
    {
        public int Id { get; set; }
        public string ?GoogleId { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string PotoUrl { get; set; }
    }
}
