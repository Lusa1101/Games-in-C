﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarsityPlug.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        public string Image = "chopper.jpeg";

    }
}