﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    public class Alco_type
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public List<Alcohol> Alcohols { get; set; }
        public Alco_type()
        {
            Alcohols = new List<Alcohol>();
        }
    }
}
