﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using KantoorApplicatie.Models.Floor;
using KantoorApplicatie.Models;
using KantoorApplicatie.Db;
using KantoorApplicatie.Controllers;

namespace KantoorApplicatie.Views
{
    public partial class RoomMaker : UserControl
    {
        //Lines and points to remember which were last added. 
        private List<Line> lines;
        private List<Point> points;
        // ColorChosen is used for checking if a color is chosen, else draw a floor.
        private bool intersects, colorChosen;
        // Floortype to draw if a color isnt chosen.
        private FloorType chosenFloorType;
        private Bitmap tempImage;
        // Color to draw if a floortype isnt chosen.
        private Color chosenColor;
        //public List<FloorType> floorTypes { get; set; }
        //public List<FloorMaterial> floorMaterial { get; set; }
        private GraphicsPath gPath;
        private Room room;
        // Used to check if user clicks in a certain area.
        private Rectangle hitbox;
        // Use mainmenu to save the room.
        private MainView mv;
        // Offset for the menubar so hitboxes work good.
        private int menuHeightOffset = -24;
        private double hitboxThreshHold = 0.8;
        public RoomMaker(MainView mv)
        {
            InitializeComponent();
            lines = new List<Line>();
            points = new List<Point>();
            intersects = false;
            colorChosen = false;
            this.mv = mv;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            gPath = new GraphicsPath();
            Pen p = new Pen(Color.Black, 6);
            Graphics g = e.Graphics;
            // Draw rectangle to show the hitbox.
            hitbox = new Rectangle((int)((Width / 2) - ((Width * hitboxThreshHold) / 2)),
                (int)((Height / 2) - ((Height * hitboxThreshHold) / 2))+ menuHeightOffset,
                (int)(Width * hitboxThreshHold),
                (int)(Height * hitboxThreshHold));
            g.DrawRectangle(p, hitbox);

            if (points.Count > 0)
            {
                // Add lines to graphics path.
                foreach (Line l in lines)
                {
                    gPath.AddLine(new Point((int)l.x1,(int)l.y1), new Point((int)l.x2, (int)l.y2));
                }
                // Draw points to see where the user clicked.
                foreach (Point point in points)
                {
                    g.FillEllipse(p.Brush, point.X - 5, point.Y - 5, 10, 10);
                }
                g.DrawPath(p, gPath);
                // Fill path if points are intersecting.
                if (intersects)
                {
                    g.SetClip(gPath, CombineMode.Replace);
                    // If a color is chosen, use that as the background.
                    if (colorChosen)
                    {
                        p.Color = chosenColor;
                    }
                    // Else use floortype as background.
                    else
                    {
                        Rectangle rect = new Rectangle(0, 0, Width, Height);
                        // For loops to fill up the background with small images.
                        for (int y = rect.Y; y < rect.Bottom; y += tempImage.Height)
                        {
                            for (int x = rect.X; x < rect.Right; x += tempImage.Width)
                            {
                                Rectangle drawRect = new Rectangle(x, y, Math.Min(tempImage.Width, rect.Right - x),
                                               Math.Min(tempImage.Height, rect.Bottom - y));
                                Rectangle imageRect = new Rectangle(0, 0, drawRect.Width, drawRect.Height);

                                g.DrawImage(tempImage, drawRect, imageRect, GraphicsUnit.Pixel);
                            }
                        }
                        p.Color = Color.Transparent;
                    }
                    g.FillPath(p.Brush, gPath);
                }
            }
        }

        // Create a point when clicked, draw a line between points if there are atleast 2 points.
        private void RoomMaker_MouseDown(object sender, MouseEventArgs e)
        {
            if (hitbox.Contains(Cursor.Position))
            {
                if (!intersects)
                {
                    // Add a new point on the position thats clicked
                    if (points.Count == 0)
                    {
                        points.Add(PointToClient(Cursor.Position));
                    }
                    // If there are more points than 1, draw a line between the last point and this point.
                    else
                    {
                        Point point2 = PointToClient(Cursor.Position);
                        lines.Add(new Line(points[points.Count - 1].X, points[points.Count - 1].Y, point2.X, point2.Y));
                        points.Add(point2);
                    }
                    Invalidate();
                }
            }
        }
            
        // Empties lists to start over.
        private void restartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u het zeker?", "Opnieuw beginnen", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lines = new List<Line>();
                points = new List<Point>();
                intersects = false;
                Invalidate();
            }
        }

        // Remove last created point/line.
        private void undoLast_Click(object sender, EventArgs e)
        {
            if(points.Count > 0)
            {
                if (lines.Count > 0)
                {
                    lines.Remove(lines[lines.Count - 1]);
                }
                points.Remove(points[points.Count - 1]);
                intersects = false;
                Invalidate();
            }
        }
        private int positionThreshHold = 10;
        // Checks if there are intersecting points in the list.
        private void Intersecting()
        {
            // find intersecting points;
            foreach (Point p in points)
            {
                // Create list of points without selected point.
                List<Point> temp = points.FindAll(v => v != p);
                foreach (Point tp in temp)
                {
                    // Hitbox to see when points hit eachother.
                    if ((p.X - positionThreshHold <= tp.X && p.X + positionThreshHold >= tp.X)
                        && (p.Y - positionThreshHold <= tp.Y && p.Y + positionThreshHold >= tp.Y))
                    {
                        // When they hit, you can fill the area.
                        intersects = true;
                        break;
                    }
                }
            }
        }

        // Show a dialog where you can choose a color to use as background.
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            // Save chosen color.
            colorChosen = true;
            chosenColor = cd.Color;
            if (!intersects)
            {
                Intersecting();
            }
            Invalidate();
        }

        // Show a dialog where you can choose a floortype to use as background.
        private void btnFloor_Click(object sender, EventArgs e)
        {
            ChooseFloor cfDialog = new ChooseFloor();
            cfDialog.ShowDialog();
            if(cfDialog.DialogResult == DialogResult.OK)
            {
                chosenFloorType = cfDialog.chosenFloorType;
                tempImage = chosenFloorType.GetImage();
                colorChosen = false;
                if (!intersects)
                {
                    Intersecting();
                }
                Invalidate();
            }
        }

        // Save the room.
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (intersects)
            {
                SaveRoom sv = new SaveRoom();
                sv.ShowDialog();
                if(sv.DialogResult == DialogResult.OK)
                {
                    room = new Room();
                    room.height = sv.height;
                    room.width = sv.width;
                    room.productList = new List<Product>();
                    if (colorChosen)
                    {
                        room.hexColor = Converter.ColorToHexString(chosenColor);
                    }
                    else
                    {
                        room.floorType = chosenFloorType;
                    }
                    DatabaseController.AddLinesToDatabase(room, lines);
                    mv.setDesignPanelRoom(room);
                    mv.Controls.Remove(this);
                }
            }
        }

        // Show tooltips when hovered over buttons.
        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip = new ToolTip();
            ToolTip.SetToolTip(saveButton, "Klaar met het maken van de kamer? Met deze knop wordt het opgeslagen.");
        }

        private void restartButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip = new ToolTip();
            ToolTip.SetToolTip(restartButton, "Is er iets fout gegaan? Met deze knop kunt u opnieuw beginnen.");

        }

        private void undoLast_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip = new ToolTip();
            ToolTip.SetToolTip(undoLast, "Is de laatst getekende lijn niet goed? Met deze knop wordt het ongedaan gemaakt.");

        }

        private void fillButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip = new ToolTip();
            ToolTip.SetToolTip(btnFloor, "Wilt u een vloer als achtergrond? Met deze knop kunt u een vloer kiezen.");
        }

        private void btnColor_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip = new ToolTip();
            ToolTip.SetToolTip(btnColor, "Wilt u een kleur als achtergrond? Met deze knop kunt u een kleur kiezen.");
        }
    }
    
}
