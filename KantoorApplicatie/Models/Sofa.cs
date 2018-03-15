﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Models
{
    public class Sofa : Product
    {
        public Sofa() {
        }

        public Sofa(string name, string description, int width, int height, double price, string ImageName) : base(name, description, width, height, price, ImageName) {
        }

        public override Product Clone()
        {
            Product copy = new Sofa(name, description, width, height, price, ImageName);
            copy.productId = productId;
            copy.active = active;
            return copy;
        }
    }
}
