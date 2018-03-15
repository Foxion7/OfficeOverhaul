using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KantoorApplicatie.Views;
using KantoorApplicatie.Db;
using KantoorApplicatie.Controllers;
using KantoorApplicatie.Models;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;

namespace KantoorApplicatie.Controllers
{
    public class DesignPanelController
    {
        private DesignPanel designPanel;
        // Used for calculating center of the object. Public for unittests.
        public float lowestXValue = 10000;
        public float highestXValue = 0;
        public float lowestYValue = 10000;
        public float highestYValue = 0;
        private int standardSquareSize = 500;

        private float xDifference;
        private float yDifference;

        private float scale;
        private float centerX;
        private float centerY;

        public DesignPanelController(DesignPanel dp)
        {
            this.designPanel = dp;
        }

        // Calculate center of the screen
        public void CalculateCenterOfScreen()
        {
            designPanel.roomX = (designPanel.Width / 2) - (designPanel.rDesign.newWidth / 2);
            designPanel.roomY = (designPanel.Height / 2) - (designPanel.rDesign.newHeight / 2);
        }

        // Calculate the scale of the room and the products.
        public float CalculateScale()
        {
            scale = designPanel.scale;
            // If the room.height is bigger than the room.width.
            if (designPanel.rDesign.height >= designPanel.rDesign.width)
            {
                scale = designPanel.rDesign.height / (float)(designPanel.Height * 0.8);
            }
            else
            {
                // If the room.width is bigger than the room.height.
                scale = designPanel.rDesign.width / (float)(designPanel.Width * 0.8);
                // If the scaled room.height is bigger than the screen height.
                if ((designPanel.rDesign.height / scale) > designPanel.Height)
                {
                    scale = designPanel.rDesign.height / (float)(designPanel.Height * 0.8);
                }
            }

            designPanel.rDesign.newHeight = designPanel.rDesign.height / scale;
            designPanel.rDesign.newWidth = designPanel.rDesign.width / scale;
            return scale;
        }

        // Make graphicspath with lines from room.
        public GraphicsPath MakeGraphicsPath()
        {
            GraphicsPath gPath = new GraphicsPath();
            Room room = designPanel.rDesign;
            // If you used shapeselect, add lines to the room.

            if(designPanel.rDesign.shape == "Square")
            {
                if(room.lines.Count <= 0)
                {
                    room.lines.Add(new Line(standardSquareSize, standardSquareSize, standardSquareSize + room.width, standardSquareSize));
                    room.lines.Add(new Line(standardSquareSize + room.width, standardSquareSize, standardSquareSize + room.width, standardSquareSize + room.height));
                    room.lines.Add(new Line(standardSquareSize + room.width, standardSquareSize + room.height, standardSquareSize, standardSquareSize + room.height));
                    room.lines.Add(new Line(standardSquareSize, standardSquareSize + room.height, standardSquareSize, standardSquareSize));

                    DatabaseController.AddLinesToDatabase(room, room.lines);
                }
            }
            if (room.lines.Count > 0)
            {
                // Get corner values to draw in the center.
                SetLowestAndHighestValuesInCorners(room.lines);
                ChangeLinePositions(room.lines);
                // Redo this because line values changed.
                SetLowestAndHighestValuesInCorners(room.lines);
                calculateDifferenceBetweenCenters(room.lines);
                foreach (Line line in room.lines)
                {
                    gPath.AddLine(line.x1, line.y1, line.x2, line.y2);
                }
            }
            return gPath;
        }

        // Changes all the positions of the lines according to the scale.
        public void ChangeLinePositions(List<Line> lines)
        {
            // Calculate differences between the highest and lowest X and highest and lowest Y.
            float maxXDifference = highestXValue - lowestXValue;
            float maxYDifference = highestYValue - lowestYValue;

            
            if(maxYDifference >= maxXDifference)
            {
                scale = maxYDifference / (designPanel.rDesign.newHeight);
            }
            else
            {
                scale = maxXDifference / (designPanel.rDesign.newWidth);

                if((maxYDifference/scale) > designPanel.rDesign.newHeight)
                {
                    scale = maxYDifference / (designPanel.rDesign.newHeight);
                }
            }

            for(int i = 0; i< lines.Count-1; i++)
            {
                xDifference = Math.Abs(lines[i].x1 - lines[i].x2);
                yDifference = Math.Abs(lines[i].y1 - lines[i].y2);

                // Calculate the differences between new line and old line.
                float newXLine = xDifference / scale;
                float lineXDifference = (Math.Abs(xDifference - newXLine));

                float newYLine = yDifference / scale;
                float lineYDifference = (Math.Abs(yDifference - newYLine));
                // Change X and Y of the figure.
                if (lines[i].x2 > lines[i].x1)
                {
                    lines[i].x2 += lineXDifference;
                }
                else
                {
                    lines[i].x2 -= lineXDifference;
                }
                if (lines[i].y2 > lines[i].y1)
                {
                    lines[i].y2 += lineYDifference;
                }
                else
                {
                    lines[i].y2 -= lineYDifference;
                }
                // Changes all lines after the last one, so the figure moves along.
                for (int j = i+1; j < lines.Count-1; j++)
                {
                    if (lines[i].x2 > lines[i].x1)
                    {
                        lines[j].x2 += lineXDifference;
                    }
                    else
                    {
                        lines[j].x2 -= lineXDifference;
                    }
                    if (lines[i].y2 > lines[i].y1)
                    {
                        lines[j].y2 += lineYDifference;
                    }
                    else
                    {
                        lines[j].y2 -= lineYDifference;
                    }
                }
                // Set the start positions of the next line equal to the finish position of the first line.
                lines[i + 1].x1 = lines[i].x2;
                lines[i + 1].y1 = lines[i].y2;
                
            }
            // Connect last line with first line.
            lines[lines.Count - 1].x2 = lines[0].x1;
            lines[lines.Count - 1].y2 = lines[0].y1;
        }

        // Make bitmap for the room
        public Bitmap MakeBitmapForRoom(GraphicsPath gPath)
        {
            Bitmap floorBitmap = new Bitmap(designPanel.Width, designPanel.Height);
            Room room = designPanel.rDesign;
            Bitmap tempImage;
            using (Graphics k = Graphics.FromImage(floorBitmap))
            {
                if (gPath != null)
                {
                    // This is what the floor shape is.
                    k.SetClip(gPath, CombineMode.Replace);
                }
                Random rand = new Random();
                // Chosen floor with a random width and height.
                
                Rectangle rect = new Rectangle((int)designPanel.roomX, (int)designPanel.roomY, (int)room.newWidth, (int)room.newHeight);
                if (room.floorType != null)
                {
                    tempImage = new Bitmap(room.floorType.GetImage(), rand.Next(room.floorType.GetImage().Width / 3, room.floorType.GetImage().Width), room.floorType.GetImage().Height);
                    // List of flips so image will be rotated randomly.
                    List<RotateFlipType> flips = new List<RotateFlipType> { RotateFlipType.Rotate180FlipNone, RotateFlipType.RotateNoneFlipX, RotateFlipType.RotateNoneFlipY, RotateFlipType.Rotate180FlipXY };
                    // Loops to fill up the background with the chosen floor
                    for (int y = rect.Y; y < rect.Bottom; y += tempImage.Height)
                    {
                        for (int x = rect.X; x < rect.Right; x += tempImage.Width)
                        {
                            tempImage = new Bitmap(room.floorType.GetImage(), rand.Next(room.floorType.GetImage().Width / 3, room.floorType.GetImage().Width), room.floorType.GetImage().Height);
                            tempImage.RotateFlip(flips[rand.Next(0, 3)]);
                            Rectangle drawRect = new Rectangle(x, y, Math.Min(tempImage.Width, rect.Right - x),
                                            Math.Min(tempImage.Height, rect.Bottom - y));
                            Rectangle imageRect = new Rectangle(0, 0, drawRect.Width, drawRect.Height);
                            k.DrawImage(tempImage, drawRect, imageRect, GraphicsUnit.Pixel);
                        }
                    }
                }
                // Fill path with transparent pen so it shows the background.
                if (gPath != null)
                {
                    using(Pen pen = new Pen(Color.Transparent))
                    {
                        if (room.floorType != null)
                        {
                            k.FillPath(pen.Brush, gPath);
                        }
                        else
                        {
                            pen.Color = Converter.HexStringToColor(room.hexColor);
                            k.FillPath(pen.Brush, gPath);
                        }
                    }
                }
            }
            // Test to see if image looks how it should.
            return floorBitmap; 
        }

        // Get lowest and highest value of each corner
        public void SetLowestAndHighestValuesInCorners(List<Line> lines)
        {
            // Set variables again for when a new room is made while program runs.
            lowestXValue = 10000;
            highestXValue = 0;
            lowestYValue = 10000;
            highestYValue = 0;
            foreach (Line line in lines)
            {
                // Gets the x thats most to the left.
                if (lowestXValue > line.x1)
                {
                    lowestXValue = line.x1;
                }
                if (lowestXValue > line.x2)
                {
                    lowestXValue = line.x2;
                }

                // Gets the x thats most to the right.
                if (highestXValue < line.x1)
                {
                    highestXValue = line.x1;
                }
                if (highestXValue < line.x2)
                {
                    highestXValue = line.x2;
                }

                // Gets the Y that is the highest
                if (lowestYValue > line.y1)
                {
                    lowestYValue = line.y1;
                }
                if (lowestYValue > line.y2)
                {
                    lowestYValue = line.y2;
                }

                //Gets the Y that is the lowest
                if (highestYValue < line.y1)
                {
                    highestYValue = line.y1;
                }
                if (highestYValue < line.y2)
                {
                    highestYValue = line.y2;
                }
            }
        }

        // Calculate center of the object.
        public void calculateDifferenceBetweenCenters(List<Line> lines)
        {
            // Calculate center of object
            centerX = ((highestXValue + lowestXValue) / 2);
            centerY = ((highestYValue + lowestYValue) / 2);
            xDifference = (designPanel.Width / 2) - centerX;
            yDifference = (designPanel.Height / 2) - centerY;

            // Set lines around the center of the screen
            foreach(Line line in lines)
            {
                line.x1 += xDifference;
                line.x2 += xDifference;
                line.y1 += yDifference;
                line.y2 += yDifference;
            }
        }
    }
}
