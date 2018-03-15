﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KantoorApplicatie.Models.Theme
{
    public class Theme
    {
        public int themeId { get; set; }
        // Name of main theme
        public string name { get; set; }
        // List of subthemes that are part of the main theme
        public virtual ICollection<SubTheme> subThemes { get; set; }

        public Theme() {
        }
        public Theme(string n)
        {
            subThemes = new List<SubTheme>();
            this.name = n;
        }
    }
}
