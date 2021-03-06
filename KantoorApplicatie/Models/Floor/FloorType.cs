﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KantoorApplicatie.Controllers;
namespace KantoorApplicatie.Models.Floor
{
    public class FloorType
    {
        public int floorTypeId { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public Byte[] image { get; set; }
        public virtual FloorMaterial floorMaterial { get; set; }

        public FloorType() {
        }

        public FloorType(string nm, float price, Bitmap img)
        {
            name = nm;
            this.price = price;
            this.image = Converter.ImageToByteArray(img);
        }

        public Bitmap GetImage()
        {
            return Converter.ByteArrayToImage(image);
        }
    }
}
