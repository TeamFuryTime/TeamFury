﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class RequestUpdateDTO
    {
        public string MessageForDecline { get; set; }
        public StatusRequest StatusRequest { get; set; }
    }
}
