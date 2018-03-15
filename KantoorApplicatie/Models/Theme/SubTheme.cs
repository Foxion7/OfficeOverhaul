using System;
using KantoorApplicatie.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KantoorApplicatie.Models.Theme
{
    public class SubTheme
    {
        public int subThemeId { get; set; }
        public virtual Theme theme{ get; set; }
        // Name of the subtheme
        public string name { get; set; }
        // Background image of the subtheme
        public Byte[] image { get; set; }
        public int lastUsed { get; set; }

        public SubTheme() {
        }

        public SubTheme(string n, Bitmap i, Theme t)
        {
            this.name = n;
            this.theme = t;
            this.image = Converter.ImageToByteArray(i);
            this.lastUsed = 0;
        }

        public Bitmap GetImage()
        {
            return Converter.ByteArrayToImage(image);
        }
    }
}
