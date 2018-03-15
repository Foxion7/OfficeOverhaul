using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Models
{
    public class Lamp : Product
    {
        public int lightRadius { get; set; }

        public Lamp() {
        }

        public Lamp(string name, string description, int width, int height, double price, string ImageName, int lightradius) : base(name, description, width, height, price, ImageName)
        {
            lightRadius = lightradius;
        }

        public override Product Clone()
        {
            Product copy = new Lamp(name, description, width, height, price, ImageName, lightRadius);
            copy.productId = productId;
            copy.active = active;
            return copy;
        }

    }
}
