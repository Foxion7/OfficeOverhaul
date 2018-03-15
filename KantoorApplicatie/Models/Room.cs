﻿using KantoorApplicatie.Models.Floor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KantoorApplicatie.Models
{
    public class Room
    {
        public int roomId { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string hexColor { get; set; }
        public float newWidth { get; set; }
        public float newHeight { get; set; }
        public string shape { get; set; }
        public virtual FloorType floorType { get; set; }
        // This list is used for the graphicspath.
        public virtual List<Line> lines{ get; set; }
        public List<Product> productList;

        public Room(int width, int height, string shape, FloorType floorType)
        {
            this.width = width;
            this.height = height;
            this.shape = shape;
            this.floorType = floorType;
        }

        public Room()
        {
            lines = new List<Line>();
        }
    }
}
